Public Class Form1
    Private Sub GosterBtn_Click(sender As Object, e As EventArgs) Handles GosterBtn.Click
        For Each btn As Button In Me.Controls.OfType(Of Button)
            If BosMasaRBtn.Checked Then
                If btn.Tag = "Boş" Then
                    btn.BackColor = Color.Green
                Else
                    btn.BackColor = Color.White
                End If

            ElseIf DoluRBtn.Checked Then
                If btn.Tag = "Dolu" Then
                    btn.BackColor = Color.Red
                Else
                    btn.BackColor = Color.White
                End If

            ElseIf RezerveRBtn.Checked Then
                If btn.Tag = "Rezerve" Then
                    btn.BackColor = Color.Yellow
                Else
                    btn.BackColor = Color.White
                End If

            ElseIf RezerveDoluRBtn.Checked Then
                If btn.Tag = "Rezerve" Then
                    btn.BackColor = Color.Pink
                ElseIf btn.Tag = "Dolu" Then
                    btn.BackColor = Color.Pink
                Else
                    btn.BackColor = Color.White
                End If
            Else
                MessageBox.Show("Lütfen bir masa tipi seçiniz.")
            End If
        Next
    End Sub

End Class
