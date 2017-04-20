PS C:\> $p = get-process
PS C:\> $result = $p | measure-object -property handles -sum -average -max
PS C:\> $result | out-file '.\ProcessHandleStats.txt'