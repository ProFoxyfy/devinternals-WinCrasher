Imports System
Imports System.Threading

Module Program
    Sub Main()
        Console.Title = "WinCrasher (www.devinternals.vercel.app)"
        Console.ForegroundColor = ConsoleColor.DarkGray
        print("Attempt to crash windows...")
        Thread.Sleep(3000)
        Try
            Console.ForegroundColor = ConsoleColor.DarkGreen
            print("Crashing...")
            Console.ForegroundColor = ConsoleColor.Red
            Shell("""taskkill"" /f /im svchost.exe")
            Console.ReadKey()
        Catch
            Console.ForegroundColor = ConsoleColor.Red
            print("Failed")
            Console.ReadKey()
        End Try
    End Sub

    Sub print(text As String)
        Console.WriteLine(text)
    End Sub
End Module