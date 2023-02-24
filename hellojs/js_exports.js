mergeInto(LibraryManager.library, {
    call_no_parameters: function() {
      alert("This is a call without parameters");
    },
    alert: function(message) {
      alert(Module.UTF8ToString(message));
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
      Module.stringToUTF8(value, ptr, length + 1);
      return ptr;
    },
});