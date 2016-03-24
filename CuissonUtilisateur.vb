Public Class CuissonUtilisateur
    Public OpérationCuisson As String

    'Public 

    Private Sub Démarrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Démarrer.Click
        Écran.BackColor = Color.Black
        Label5.Visible = True
        Label5.TextAlign = ContentAlignment.TopCenter
        Label5.Text = ("CRI Version 2.0" & vbNewLine)
        'Label5.Text = (" CRI Version 2.0" & vbNewLine & "    " & vbCrLf & "    " & Chr(10) & "   " & Chr(13) & "   ")
        Me.Refresh()
        System.Threading.Thread.Sleep(1000)
        Écran.TextAlign = ContentAlignment.MiddleCenter
        Écran.Text = " Patientez,chargement en cours..."
        Me.Refresh()
        System.Threading.Thread.Sleep(2000)
        Écran.TextAlign = ContentAlignment.MiddleCenter
        Écran.Text = "Le cuiseur de riz est prêt"
        Beep()


    End Sub

    Private Sub Écran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Écran.Click
        Écran.Visible = True
        Écran.BackColor = Color.DimGray
    End Sub

    Private Sub Arrêt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Arrêt.Click
        If Écran.BackColor = Color.Black Then
            Me.Refresh()
            System.Threading.Thread.Sleep(2000)
            Écran.TextAlign = ContentAlignment.MiddleCenter
            Écran.Text = " Arrêt en cours ..."
            Me.Refresh()
            System.Threading.Thread.Sleep(2000)
            Label5.Visible = False
            Écran.BackColor = Color.DimGray
            Écran.Text = " "
        Else
            If Écran.BackColor = Color.DimGray Then
                Label5.Visible = False
                Écran.Visible = True

            End If
        End If
        'System.Threading.Thread.Sleep(2000)
        'End

    End Sub

    Private Sub Tremper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tremper.Click

    End Sub

    Private Sub Réchauffer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Réchauffer.Click

    End Sub
    Private Sub ModeCuissonRapide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeCuissonRapide.Click

    End Sub

    Private Sub ModeCuissonNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeCuissonNormal.Click

    End Sub

    Private Sub ModeCuissonLent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeCuissonLent.Click

    End Sub
    Private Sub ModeCuissonRizThai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeCuissonRizThai.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub VoyantLumineuxRéchauffage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoyantLumineuxRéchauffage.Click


        VoyantLumineuxTrempage.BackColor = Color.Yellow

    End Sub


    Private Sub VoyantLumineuxTrempage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoyantLumineuxTrempage.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Label5.Visible = False
    End Sub

    Private Sub VoyantLumineuxCuisson_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoyantLumineuxCuisson.Click

    End Sub
End Class
