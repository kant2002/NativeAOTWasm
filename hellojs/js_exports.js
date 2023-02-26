mergeInto(LibraryManager.library, {
    call_no_parameters: function() {
      alert("This is a call without parameters");
    },
    alert: function(message) {
      alert(UTF8ToString(message));
    },
    get_int: function() {
      return 42;
    },
    get_double: function() {
      return 0.5;
    },
    get_string: function() {
      const value = "This is string from JS";
      const length = lengthBytesUTF8(value);
      const ptr = _malloc(length + 1);
      stringToUTF8(value, ptr, length + 1);
      return ptr;
    },
    int_parameter: function(intOutPtr, intRefPtr) {
      HEAP32[intOutPtr / 4] = 100;
      HEAP32[intRefPtr / 4] = HEAP32[intRefPtr / 4] + 17;
    },
    bool_parameter: function(trueOutPtr, falseOutPtr) {
      HEAP32[trueOutPtr / 4] = true;
      HEAP32[falseOutPtr / 4] = true;
    },
});