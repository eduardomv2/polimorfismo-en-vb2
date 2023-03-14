Class ProgramHelpers
    Public Shared Sub AnimalSound(animal As IAnimal)
        If animal Is Nothing Then
            Throw New ArgumentNullException(NameOf(animal))
        End If

        animal.MakeSound()
    End Sub
End Class
