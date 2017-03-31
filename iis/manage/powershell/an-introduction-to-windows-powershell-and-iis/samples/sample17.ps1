PS C:\> get-process |
        measure-object handles -sum |
        out-gauge -value sum -refresh 0:0:1 -float -type