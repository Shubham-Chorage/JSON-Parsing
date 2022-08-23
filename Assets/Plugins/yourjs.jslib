mergeInto(LibraryManager.library, {
    ShowMessage: function (message){
        window.alert(Pointer.stringify(message));
    },
});