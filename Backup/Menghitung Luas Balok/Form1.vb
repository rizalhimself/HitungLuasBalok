Public Class Form1

    Private Sub junlahkanbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles junlahkanbutton.Click
        hasiltextbox.Text = Val(panjangtextbox.Text) * Val(lebartextbox.Text) * Val(tinggitextbox.Text)
        luaspermukaantextbox.Text = (2 * Val(panjangtextbox.Text) * Val(lebartextbox.Text)) + (2 * Val(panjangtextbox.Text) * Val(tinggitextbox.Text)) + (2 * Val(lebartextbox.Text) * Val(tinggitextbox.Text))
    End Sub

End Class
