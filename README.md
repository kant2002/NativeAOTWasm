Experiments with NativeAOT WASM
===============================

# Well known properties

List of properties which I want to see in the SDK.
- `WasmHasCanvas` enable displaying of canvas on the default template. True by default.

# Well known items
List of properties which I want to see in the SDK. These items mostly to plug additional JS files into MSBuild dependency tracking.
- `EmscriptenPostJs` Allow pass files to `--post-js`.
- `EmscriptenLibrary` Allow pass files to `--js-library`.

# Steps how to add support for NativeAOT-LLVM

Add following block to your project
```xml
  <PropertyGroup>
    <!-- This is required to opt-out of Mono WASM workloads -->
    <MSBuildEnableWorkloadResolver>false</MSBuildEnableWorkloadResolver>
    <!-- Just use dotnet publish since we are unlikely support other RID with this configuration. -->
    <RuntimeIdentifier>browser-wasm</RuntimeIdentifier>
    <!-- PublishAot must be not be set -->
    <!-- <PublishAot>true</PublishAot> -->
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.DotNet.ILCompiler.LLVM" Version="8.0.0-*" />
    <PackageReference Include="runtime.win-x64.Microsoft.DotNet.ILCompiler.LLVM" Version="8.0.0-*" />
    <PackageReference Include="Microsoft.NET.ILLink.Tasks" Version="8.0.0-*" Condition="'$(ILLinkTargetsPath)' == ''" />
  </ItemGroup>
```

If you want play with WASI, in additional to steps above install `dotnet workload install wasi-experimental` and add `<IsWasiProject>false</IsWasiProject>` to your project to opt-out of WASI-Sdk tooling.

If you want to use `wasmtime` also add
```
<ItemGroup>
    <LinkerArg Include="-Wl,--import-memory,--export-memory" />
</ItemGroup>
```

For wasmtime you should enable threading `--enable-threads --wasi-modules experimental-wasi-threads`

# How to test
```
cd helloworld
& $env:EMSDK_HOME\emsdk.ps1 activate 3.1.23
dotnet publish
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