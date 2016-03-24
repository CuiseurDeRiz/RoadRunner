<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuissonUtilisateur
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Démarrer = New System.Windows.Forms.Button
        Me.Arrêt = New System.Windows.Forms.Button
        Me.Écran = New System.Windows.Forms.Label
        Me.Tremper = New System.Windows.Forms.Button
        Me.Réchauffer = New System.Windows.Forms.Button
        Me.ModeCuissonRapide = New System.Windows.Forms.Button
        Me.ModeCuissonNormal = New System.Windows.Forms.Button
        Me.ModeCuissonLent = New System.Windows.Forms.Button
        Me.ModeCuissonRizThai = New System.Windows.Forms.Button
        Me.VoyantLumineuxRéchauffage = New System.Windows.Forms.PictureBox
        Me.VoyantLumineuxCuisson = New System.Windows.Forms.PictureBox
        Me.VoyantLumineuxTrempage = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.VoyantLumineuxRéchauffage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoyantLumineuxCuisson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoyantLumineuxTrempage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Démarrer
        '
        Me.Démarrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Démarrer.ForeColor = System.Drawing.Color.White
        Me.Démarrer.Location = New System.Drawing.Point(164, 80)
        Me.Démarrer.Name = "Démarrer"
        Me.Démarrer.Size = New System.Drawing.Size(62, 23)
        Me.Démarrer.TabIndex = 0
        Me.Démarrer.Text = "Démarrer"
        Me.Démarrer.UseVisualStyleBackColor = True
        '
        'Arrêt
        '
        Me.Arrêt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Arrêt.Location = New System.Drawing.Point(232, 80)
        Me.Arrêt.Name = "Arrêt"
        Me.Arrêt.Size = New System.Drawing.Size(53, 23)
        Me.Arrêt.TabIndex = 1
        Me.Arrêt.Text = "Arrêter"
        Me.Arrêt.UseVisualStyleBackColor = True
        '
        'Écran
        '
        Me.Écran.AutoSize = True
        Me.Écran.BackColor = System.Drawing.Color.DimGray
        Me.Écran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Écran.ForeColor = System.Drawing.Color.Cyan
        Me.Écran.Location = New System.Drawing.Point(95, 120)
        Me.Écran.MaximumSize = New System.Drawing.Size(300, 400)
        Me.Écran.MinimumSize = New System.Drawing.Size(350, 150)
        Me.Écran.Name = "Écran"
        Me.Écran.Size = New System.Drawing.Size(350, 150)
        Me.Écran.TabIndex = 2
        Me.Écran.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Tremper
        '
        Me.Tremper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tremper.ForeColor = System.Drawing.Color.White
        Me.Tremper.Location = New System.Drawing.Point(291, 80)
        Me.Tremper.Name = "Tremper"
        Me.Tremper.Size = New System.Drawing.Size(74, 23)
        Me.Tremper.TabIndex = 3
        Me.Tremper.Text = "Trempage"
        Me.Tremper.UseVisualStyleBackColor = True
        '
        'Réchauffer
        '
        Me.Réchauffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Réchauffer.ForeColor = System.Drawing.Color.White
        Me.Réchauffer.Location = New System.Drawing.Point(371, 80)
        Me.Réchauffer.Name = "Réchauffer"
        Me.Réchauffer.Size = New System.Drawing.Size(74, 23)
        Me.Réchauffer.TabIndex = 4
        Me.Réchauffer.Text = "Réchaud"
        Me.Réchauffer.UseVisualStyleBackColor = True
        '
        'ModeCuissonRapide
        '
        Me.ModeCuissonRapide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModeCuissonRapide.ForeColor = System.Drawing.Color.White
        Me.ModeCuissonRapide.Location = New System.Drawing.Point(164, 42)
        Me.ModeCuissonRapide.Name = "ModeCuissonRapide"
        Me.ModeCuissonRapide.Size = New System.Drawing.Size(62, 23)
        Me.ModeCuissonRapide.TabIndex = 7
        Me.ModeCuissonRapide.Text = "Rapide"
        Me.ModeCuissonRapide.UseVisualStyleBackColor = True
        '
        'ModeCuissonNormal
        '
        Me.ModeCuissonNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModeCuissonNormal.Location = New System.Drawing.Point(232, 42)
        Me.ModeCuissonNormal.Name = "ModeCuissonNormal"
        Me.ModeCuissonNormal.Size = New System.Drawing.Size(53, 23)
        Me.ModeCuissonNormal.TabIndex = 6
        Me.ModeCuissonNormal.Text = "Normal"
        Me.ModeCuissonNormal.UseVisualStyleBackColor = True
        '
        'ModeCuissonLent
        '
        Me.ModeCuissonLent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModeCuissonLent.ForeColor = System.Drawing.Color.White
        Me.ModeCuissonLent.Location = New System.Drawing.Point(291, 42)
        Me.ModeCuissonLent.Name = "ModeCuissonLent"
        Me.ModeCuissonLent.Size = New System.Drawing.Size(74, 23)
        Me.ModeCuissonLent.TabIndex = 5
        Me.ModeCuissonLent.Text = "Lent"
        Me.ModeCuissonLent.UseVisualStyleBackColor = True
        '
        'ModeCuissonRizThai
        '
        Me.ModeCuissonRizThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModeCuissonRizThai.ForeColor = System.Drawing.Color.White
        Me.ModeCuissonRizThai.Location = New System.Drawing.Point(371, 42)
        Me.ModeCuissonRizThai.Name = "ModeCuissonRizThai"
        Me.ModeCuissonRizThai.Size = New System.Drawing.Size(74, 23)
        Me.ModeCuissonRizThai.TabIndex = 8
        Me.ModeCuissonRizThai.Text = "Riz Thai"
        Me.ModeCuissonRizThai.UseVisualStyleBackColor = True
        '
        'VoyantLumineuxRéchauffage
        '
        Me.VoyantLumineuxRéchauffage.BackColor = System.Drawing.Color.LightGray
        Me.VoyantLumineuxRéchauffage.Location = New System.Drawing.Point(13, 84)
        Me.VoyantLumineuxRéchauffage.Name = "VoyantLumineuxRéchauffage"
        Me.VoyantLumineuxRéchauffage.Size = New System.Drawing.Size(75, 10)
        Me.VoyantLumineuxRéchauffage.TabIndex = 9
        Me.VoyantLumineuxRéchauffage.TabStop = False
        '
        'VoyantLumineuxCuisson
        '
        Me.VoyantLumineuxCuisson.BackColor = System.Drawing.Color.LightGray
        Me.VoyantLumineuxCuisson.Location = New System.Drawing.Point(13, 68)
        Me.VoyantLumineuxCuisson.Name = "VoyantLumineuxCuisson"
        Me.VoyantLumineuxCuisson.Size = New System.Drawing.Size(75, 10)
        Me.VoyantLumineuxCuisson.TabIndex = 10
        Me.VoyantLumineuxCuisson.TabStop = False
        '
        'VoyantLumineuxTrempage
        '
        Me.VoyantLumineuxTrempage.BackColor = System.Drawing.Color.LightGray
        Me.VoyantLumineuxTrempage.Location = New System.Drawing.Point(13, 52)
        Me.VoyantLumineuxTrempage.Name = "VoyantLumineuxTrempage"
        Me.VoyantLumineuxTrempage.Size = New System.Drawing.Size(75, 10)
        Me.VoyantLumineuxTrempage.TabIndex = 11
        Me.VoyantLumineuxTrempage.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 85)
        Me.Label2.MaximumSize = New System.Drawing.Size(80, 13)
        Me.Label2.MinimumSize = New System.Drawing.Size(60, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Réchauffage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 68)
        Me.Label3.MaximumSize = New System.Drawing.Size(80, 13)
        Me.Label3.MinimumSize = New System.Drawing.Size(60, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Cuisson"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 52)
        Me.Label4.MaximumSize = New System.Drawing.Size(80, 13)
        Me.Label4.MinimumSize = New System.Drawing.Size(60, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Trempage"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Aqua
        Me.Label5.Location = New System.Drawing.Point(205, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'CuissonUtilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(476, 280)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.VoyantLumineuxTrempage)
        Me.Controls.Add(Me.VoyantLumineuxCuisson)
        Me.Controls.Add(Me.VoyantLumineuxRéchauffage)
        Me.Controls.Add(Me.ModeCuissonRizThai)
        Me.Controls.Add(Me.ModeCuissonRapide)
        Me.Controls.Add(Me.ModeCuissonNormal)
        Me.Controls.Add(Me.ModeCuissonLent)
        Me.Controls.Add(Me.Réchauffer)
        Me.Controls.Add(Me.Tremper)
        Me.Controls.Add(Me.Écran)
        Me.Controls.Add(Me.Arrêt)
        Me.Controls.Add(Me.Démarrer)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CuissonUtilisateur"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "                                        Interface CRI"
        CType(Me.VoyantLumineuxRéchauffage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoyantLumineuxCuisson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoyantLumineuxTrempage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Démarrer As System.Windows.Forms.Button
    Friend WithEvents Arrêt As System.Windows.Forms.Button
    Friend WithEvents Écran As System.Windows.Forms.Label
    Friend WithEvents Tremper As System.Windows.Forms.Button
    Friend WithEvents Réchauffer As System.Windows.Forms.Button
    Friend WithEvents ModeCuissonRapide As System.Windows.Forms.Button
    Friend WithEvents ModeCuissonNormal As System.Windows.Forms.Button
    Friend WithEvents ModeCuissonLent As System.Windows.Forms.Button
    Friend WithEvents ModeCuissonRizThai As System.Windows.Forms.Button
    Friend WithEvents VoyantLumineuxRéchauffage As System.Windows.Forms.PictureBox
    Friend WithEvents VoyantLumineuxCuisson As System.Windows.Forms.PictureBox
    Friend WithEvents VoyantLumineuxTrempage As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
