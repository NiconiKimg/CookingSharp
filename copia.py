import os

def generar_informacion_archivos(directorio_raiz, extensiones_permitidas=None, directorios_excluidos=None, archivos_excluidos=None):
    if extensiones_permitidas is None:
        extensiones_permitidas = []
    if directorios_excluidos is None:
        directorios_excluidos = []
    if archivos_excluidos is None:
        archivos_excluidos = []

    output = []
    for dirpath, dirnames, filenames in os.walk(directorio_raiz):
        # Excluir directorios especificados (sigue siendo una buena práctica)
        dirnames[:] = [d for d in dirnames if d not in directorios_excluidos]

        for filename in filenames:
            if filename in archivos_excluidos:
                continue

            # --- CAMBIO CLAVE ---
            # Si la lista de extensiones NO está vacía, solo incluimos archivos que terminen en esas extensiones.
            # Esto ignora automáticamente imágenes, librerías, etc.
            if extensiones_permitidas and not any(filename.endswith(ext) for ext in extensiones_permitidas):
                continue

            file_path = os.path.join(dirpath, filename)
            relative_path = os.path.relpath(file_path, directorio_raiz)
            
            try:
                with open(file_path, 'r', encoding='utf-8', errors='ignore') as file:
                    content = file.read()
                    output.append(f"{relative_path.replace(os.sep, '/')}\n{content}\n---")
            except Exception as e:
                output.append(f"No se pudo leer el archivo: {relative_path.replace(os.sep, '/')}\nError: {e}\n---")
    
    return "\n".join(output)

if __name__ == "__main__":
    # --- CONFIGURACIÓN ---
    ruta_del_proyecto = "." 

    # (IMPORTANTE) Ahora definimos una "lista blanca" de las extensiones que SÍ queremos.
    # He incluido las más comunes para un proyecto .NET con C#, Web y Windows Forms.
    extensiones = [
        '.cs',         # Archivos de C#
        '.razor',
        '.csproj',     # Archivos de proyecto
        '.sln',        # Archivo de solución
        '.json',       # Archivos de configuración como appsettings.json
        '.config',     # Archivos de configuración como App.config o Web.config
        '.xaml',       # Para proyectos WPF/MAUI (por si acaso)
        '.cshtml',     # Para proyectos web con Razor
        '.js',         # Tus archivos de JavaScript (no los de librerías)
        '.css',        # Tus archivos de CSS
        '.html',       # Archivos HTML
        '.md',         # Archivos Markdown como README.md
        '.gitignore',
        '.gitattributes'
    ]

    # Mantenemos la exclusión de carpetas como una segunda capa de seguridad.
    # Agregué 'node_modules' por si estuviera dentro de FrontWeb.
    directorios_a_excluir = [
        'bin', 
        'obj', 
        '.vs', 
        'packages',
        'node_modules' # Muy importante para la carpeta FrontWeb
        ]
    
    archivos_a_excluir = []

    # --- EJECUCIÓN ---
    informacion_completa = generar_informacion_archivos(
        ruta_del_proyecto,
        extensiones_permitidas=extensiones,
        directorios_excluidos=directorios_a_excluir,
        archivos_excluidos=archivos_a_excluir
    )
    
    with open("informacion_proyecto.txt", "w", encoding='utf-8') as outfile:
        outfile.write(informacion_completa)

    print("¡Proceso completado! El archivo 'informacion_proyecto.txt' debería ser mucho más ligero ahora.")
    print(f"Se incluyeron únicamente archivos con las extensiones: {extensiones}")
    print(f"Se excluyeron las siguientes carpetas: {directorios_a_excluir}")