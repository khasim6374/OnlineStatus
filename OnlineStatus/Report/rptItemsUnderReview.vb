Public Class rptItemsUnderReview

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ORItemsUnderReview_SPTableAdapter.GetData((New SqlDb).GetUserDataBase())
    End Sub
End Class