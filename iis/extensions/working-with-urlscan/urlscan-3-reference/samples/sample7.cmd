[DenyUrlSequences]
..    ; Deny directory traversals.
./    ; Deny trailing dot on a directory name.
\     ; Deny backslashes in URL.
:     ; Deny access to alternate streams.
%     ; Deny escaping after normalization.
&     ; Deny running multiple CGI processes on a single request.