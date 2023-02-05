Experiments with NativeAOT WASM
===============================

# Well known properties

List of properties whih I wan to see in the SDK.
- `WasmShellFile` file name which would have HTML template for the generated WASM file. Applicable only to EXE targets. DLL probably should not need that. 
- `WasmHasCanvas` enable displaying of canvas on the default template. True by default.

# How to test
```
& $env:EMSDK_HOME\emsdk.ps1 activate 3.1.23
dotnet publish --self-contained -r browser-wasm /p:msBuildEnableWorkloadResolver=false /p:EmitLegacyAssetsFileItems=true
npx http-server bin/Debug/net7.0/browser-wasm/publish/
```