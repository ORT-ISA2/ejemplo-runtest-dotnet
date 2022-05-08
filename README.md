# Ejemplo - Ejecutar tests en .Net
Ejecutar los tests y obtener el reporte con GitHub Actions en .net

## Estructura del repositorio

- console-app: Proyecto de consola en .net 5.0
  - console-app: aplicación de consola
  - console-app-test: proyecto de MSTests
- .github/workflows: Archivo yml con el job de build


## Links de referencia
- Documentación de .net: https://docs.microsoft.com/en-us/dotnet/devops/dotnet-test-github-action
- Documentación de GitHub Actions: https://docs.github.com/en/actions/learn-github-actions/understanding-github-actions
- Documentación de comandos utilizados:
  - checkout: https://github.com/actions/checkout
  - setup-dotnet: https://github.com/actions/setup-dotnet
  - upload-artifact: https://github.com/actions/upload-artifact
