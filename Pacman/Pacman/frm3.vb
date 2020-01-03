Public Class frm3

    Private Sub tmrfly_Tick(sender As System.Object, e As System.EventArgs) Handles tmrfly.Tick
        lbl1.Left -= 10
        lbl2.Left -= 10
        lbl3.Left -= 10
        lbl4.Left -= 10
        lbl5.Left -= 10
        lbl6.Left -= 10
        lbl7.Left -= 10
        If lbl1.Location.X <= 35 Then
            tmrfly.Enabled = False
        End If
    End Sub

    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click
        Me.Close()
    End Sub

    Private Sub frm3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class