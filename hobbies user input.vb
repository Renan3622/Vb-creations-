'Visual Basic.Net Compiler version 0.0.0.5943 (Mono 4.0.1)

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions

Namespace Dcoder
  Public Module Program
    Public Sub Main(args() As string)
      'Your code goes here
      Dim escolha As String

        Console.WriteLine("escolha 1.Desenhos,2.Musicas,3.Poesias")
        escolha = Console.ReadLine()
        Console.WriteLine("opção" + escolha)
        Console.WriteLine(TypeName(escolha)) 
        escolha = Console.ReadLine()
        
    End Sub
  End Module
End Namespace