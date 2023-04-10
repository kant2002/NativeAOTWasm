Experiments with NativeAOT WASM
===============================

# Well known properties

List of properties which I want to see in the SDK.
- `WasmHasCanvas` enable displaying of canvas on the default template. True by default.

# Well known items
List of properties which I want to see in the SDK. These items mostly to plug additional JS files into MSBuild dependency tracking.
- `EmscriptenPostJs` Allow pass files to `--post-js`.
- `EmscriptenLibrary` Allow pass files to `--js-library`.

# How to test
```
cd helloworld
& $env:EMSDK_HOME\emsdk.ps1 activate 3.1.23
dotnet publish --self-contained -r browser-wasm /p:msBuildEnableWorkloadResolver=false
npx http-server bin/Debug/net7.0/browser-wasm/publish/
```

# Prerequiresites

```
git clone https://github.com/emscripten-core/emsdk ../emsdk
cd ../emsdk
git checkout b4fd475
cd ../nativeaotwasm
```
Set `$env:EMSDK_HOME` to `emsdk` folder.