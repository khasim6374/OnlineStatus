Public Class rptBusinessunitanalysisChart

    Private Sub XrChart1_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrChart1.BeforePrint


    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        OREntity_spTableAdapter.GetData((New SqlDb).GetUserDataBase())
    End Sub
End Class