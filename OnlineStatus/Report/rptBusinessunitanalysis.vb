Public Class rptBusinessunitanalysis

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        OREntity_spTableAdapter.GetData((New SqlDb).GetUserDataBase())
    End Sub
End Class