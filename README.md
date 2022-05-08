# Ejemplo - Ejecutar tests en .Net
Ejecutar los tests y obtener el reporte con GitHub Actions en .net

## Estructura del repositorio

- .github/workflows: Archivo yml con el job de build
- assets: imágenes para el readme
- console-app: Proyecto de consola en .net 5.0
  - console-app: aplicación de consola
  - console-app-test: proyecto de MSTests


## Reporte con los resultados

- Ejemplo de resultado con errores: https://github.com/ORT-ISA2/ejemplo-runtest-dotnet/runs/6343402563?check_suite_focus=true
![Resultado con errores](https://github.com/ORT-ISA2/ejemplo-runtest-dotnet/blob/main/assets/resultado-error.png)

- Ejemplo de resultado con todo ok: https://github.com/ORT-ISA2/ejemplo-runtest-dotnet/runs/6343419010?check_suite_focus=true
![Resultado ok](https://github.com/ORT-ISA2/ejemplo-runtest-dotnet/blob/main/assets/resultado-ok.png)

## Links de referencia
- Documentación de .net: https://docs.microsoft.com/en-us/dotnet/devops/dotnet-test-github-action
- Documentación de GitHub Actions: https://docs.github.com/en/actions/learn-github-actions/understanding-github-actions
- Documentación de comandos utilizados:
  - checkout: https://github.com/actions/checkout
  - setup-dotnet: https://github.com/actions/setup-dotnet
  - upload-artifact: https://github.com/actions/upload-artifact
- Documentación de creación del reporte: https://github.com/dorny/test-reporter
