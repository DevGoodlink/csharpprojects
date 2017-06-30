Public Class Vehicule
    Private numImm As String
    Private model As String
    Private couleur As String

    Public Property NumImm1 As String
        Get
            Return numImm
        End Get
        Set(value As String)
            numImm = value
        End Set
    End Property

    Public Property Model1 As String
        Get
            Return model
        End Get
        Set(value As String)
            model = value
        End Set
    End Property

    Public Property Couleur1 As String
        Get
            Return couleur
        End Get
        Set(value As String)
            couleur = value
        End Set
    End Property
End Class
