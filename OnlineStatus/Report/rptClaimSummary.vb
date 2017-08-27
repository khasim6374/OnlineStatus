
Public Class rptClaimSummary


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        OrClaimSummary_spTableAdapter1.GetData((New SqlDb).GetUserDataBase())
    End Sub
End Class