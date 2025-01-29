
<h1 align="center">VirtualReality</h1>

<p align="center">
<img src="./Logos/logo.jpg" height="100">
</p>

Bienvenido al repositorio del curso de Realidad Virtual. Este curso está diseñado para los estudiantes e investigadores interesados en el campo de la Realidad Virual y cubre desde conceptos básicos hasta aplicaciones del uso de herramientas computacionales en el desarrollo de entornos con sistemas de interfaces naturales.


# Horario de clase

- `Miercoles`: 1:00 pm a 3:30 pm

<a href="https://virtual.umariana.edu.co/campus/course/view.php?id=2275" target="_blank">Enlace a plataforma académica Formación Brader</a>


<!-- Este repositorio está organizado de la siguiente manera:

- `logos/`: Carpeta que contiene los logos relacionados con el curso.
- `código/`: Ejemplos de código fuente en Python para diferentes módulos del curso.
- `README.md`: Este archivo, que proporciona una visión general y guía sobre el repositorio. -->

## Unidad Uno:
Control de versiones con github

Sesión Magistral abordando los siguientes temas:
- Instalación de GitHub Desktop
- Configuracion de Unity Hub
- Instalación de Unity 2022.2.21f1
- Instalación de git lfs
- Creación de ramas

<a href="https://desktop.github.com/download/" target="_blank">- Github Desktop </a>

<a href="https://unity.com/es/download" target="_blank">- Unity Hub </a>


### Instalación de Git LFS

Abra una terminal en la ruta del proyecto y escriba los comandos

```bash
git lfs install

```
Crear archivo de atributos (.gitattributes)
```bash
git lfs track ".mp4"

```

Modificar el archivo de atributos

```bash
## Unity ##

*.cs diff=csharp text
*.cginc text
*.shader text

*.mat merge=unityyamlmerge eol=lf
*.anim merge=unityyamlmerge eol=lf
*.unity merge=unityyamlmerge eol=lf
*.prefab merge=unityyamlmerge eol=lf
*.physicsMaterial2D merge=unityyamlmerge eol=lf
*.physicMaterial merge=unityyamlmerge eol=lf
*.asset merge=unityyamlmerge eol=lf
*.meta merge=unityyamlmerge eol=lf
*.controller merge=unityyamlmerge eol=lf


## git-lfs ##

#Image
*.jpg filter=lfs diff=lfs merge=lfs -text
*.jpeg filter=lfs diff=lfs merge=lfs -text
*.png filter=lfs diff=lfs merge=lfs -text
*.gif filter=lfs diff=lfs merge=lfs -text
*.psd filter=lfs diff=lfs merge=lfs -text
*.ai filter=lfs diff=lfs merge=lfs -text

#Audio
*.mp3 filter=lfs diff=lfs merge=lfs -text
*.wav filter=lfs diff=lfs merge=lfs -text
*.ogg filter=lfs diff=lfs merge=lfs -text

#Video
*.mp4 filter=lfs diff=lfs merge=lfs -text
*.mov filter=lfs diff=lfs merge=lfs -text

#3D Object
*.FBX filter=lfs diff=lfs merge=lfs -text
*.fbx filter=lfs diff=lfs merge=lfs -text
*.blend filter=lfs diff=lfs merge=lfs -text
*.obj filter=lfs diff=lfs merge=lfs -text

#ETC
*.a filter=lfs diff=lfs merge=lfs -text
*.exr filter=lfs diff=lfs merge=lfs -text
*.tga filter=lfs diff=lfs merge=lfs -text
*.pdf filter=lfs diff=lfs merge=lfs -text
*.zip filter=lfs diff=lfs merge=lfs -text
*.dll filter=lfs diff=lfs merge=lfs -text
*.unitypackage filter=lfs diff=lfs merge=lfs -text
*.aif filter=lfs diff=lfs merge=lfs -text
*.ttf filter=lfs diff=lfs merge=lfs -text
*.rns filter=lfs diff=lfs merge=lfs -text
*.reason filter=lfs diff=lfs merge=lfs -text
*.lxo filter=lfs diff=lfs merge=lfs -text

```

### Referencias


<a href="https://gist.github.com/nemotoo/b8a1c3a0f1225bb9231979f389fd4f3f" target="_blank">- Unity atributos </a>


<a href="https://git-lfs.com/" target="_blank">- Git lfs </a>