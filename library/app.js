Module['postRun'].push(function () {
    alert("Method from WASM module returned: " + Module.asm.Method());
});
  