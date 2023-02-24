mergeInto(LibraryManager.library, {
    call_no_parameters: function() {
      alert("This is a call without parameters");
    },
    /*alert: function(message) {
      alert(message);
    },*/
    get_int: function() {
      return 42;
    },
    get_double: function() {
      return 0.5;
    },
    /*get_string: function() {
      return "This is string from JS";
    },*/
});