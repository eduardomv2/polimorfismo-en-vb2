Imports System

Interface IAnimal
    Sub MakeSound()
End Interface

Public Class Dog
    Implements IAnimal

    Public Sub MakeSound() Implements IAnimal.MakeSound
        Console.WriteLine("Woof!")
    End Sub

End Class

Public Class Cat
    Implements IAnimal

    Public Sub MakeSound() Implements IAnimal.MakeSound
        Console.WriteLine("Meow!")
    End Sub

End Class

Public Class Program
    Public Shared Sub AnimalSound(ByVal animal As IAnimal)
        animal.MakeSound()
    End Sub

    Public Shared Sub Main()
        Dim dog As IAnimal = New Dog()
        Dim cat As IAnimal = New Cat()
        AnimalSound(dog)
        AnimalSound(cat)
    End Sub
End Class