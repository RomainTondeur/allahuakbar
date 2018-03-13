<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.imgRoulette = New System.Windows.Forms.PictureBox()
        Me.imgTapisRoulette = New System.Windows.Forms.PictureBox()
        Me.txtMise = New System.Windows.Forms.TextBox()
        Me.lblMise = New System.Windows.Forms.Label()
        Me.btnAjout10 = New System.Windows.Forms.Button()
        Me.btnRetrait10 = New System.Windows.Forms.Button()
        Me.btnValiderMise = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.imgRoulette, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTapisRoulette, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgRoulette
        '
        Me.imgRoulette.BackColor = System.Drawing.Color.Transparent
        Me.imgRoulette.Image = CType(resources.GetObject("imgRoulette.Image"), System.Drawing.Image)
        Me.imgRoulette.Location = New System.Drawing.Point(12, 12)
        Me.imgRoulette.Name = "imgRoulette"
        Me.imgRoulette.Size = New System.Drawing.Size(500, 500)
        Me.imgRoulette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgRoulette.TabIndex = 0
        Me.imgRoulette.TabStop = False
        '
        'imgTapisRoulette
        '
        Me.imgTapisRoulette.Image = CType(resources.GetObject("imgTapisRoulette.Image"), System.Drawing.Image)
        Me.imgTapisRoulette.Location = New System.Drawing.Point(518, 34)
        Me.imgTapisRoulette.Name = "imgTapisRoulette"
        Me.imgTapisRoulette.Size = New System.Drawing.Size(803, 405)
        Me.imgTapisRoulette.TabIndex = 1
        Me.imgTapisRoulette.TabStop = False
        '
        'txtMise
        '
        Me.txtMise.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtMise.Location = New System.Drawing.Point(27, 25)
        Me.txtMise.Name = "txtMise"
        Me.txtMise.ReadOnly = True
        Me.txtMise.Size = New System.Drawing.Size(100, 20)
        Me.txtMise.TabIndex = 2
        Me.txtMise.Text = "10"
        Me.txtMise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMise
        '
        Me.lblMise.AutoSize = True
        Me.lblMise.Location = New System.Drawing.Point(63, 9)
        Me.lblMise.Name = "lblMise"
        Me.lblMise.Size = New System.Drawing.Size(29, 13)
        Me.lblMise.TabIndex = 3
        Me.lblMise.Text = "Mise"
        '
        'btnAjout10
        '
        Me.btnAjout10.Location = New System.Drawing.Point(27, 51)
        Me.btnAjout10.Name = "btnAjout10"
        Me.btnAjout10.Size = New System.Drawing.Size(100, 23)
        Me.btnAjout10.TabIndex = 4
        Me.btnAjout10.Text = "Ajouter 10 millions"
        Me.btnAjout10.UseVisualStyleBackColor = True
        '
        'btnRetrait10
        '
        Me.btnRetrait10.Location = New System.Drawing.Point(27, 80)
        Me.btnRetrait10.Name = "btnRetrait10"
        Me.btnRetrait10.Size = New System.Drawing.Size(100, 23)
        Me.btnRetrait10.TabIndex = 5
        Me.btnRetrait10.Text = "Retirer 10 millions"
        Me.btnRetrait10.UseVisualStyleBackColor = True
        '
        'btnValiderMise
        '
        Me.btnValiderMise.Location = New System.Drawing.Point(27, 109)
        Me.btnValiderMise.Name = "btnValiderMise"
        Me.btnValiderMise.Size = New System.Drawing.Size(100, 23)
        Me.btnValiderMise.TabIndex = 6
        Me.btnValiderMise.Text = "Valider"
        Me.btnValiderMise.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMise)
        Me.GroupBox1.Controls.Add(Me.btnValiderMise)
        Me.GroupBox1.Controls.Add(Me.txtMise)
        Me.GroupBox1.Controls.Add(Me.btnRetrait10)
        Me.GroupBox1.Controls.Add(Me.btnAjout10)
        Me.GroupBox1.Location = New System.Drawing.Point(518, 445)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(643, 148)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1318, 605)
        Me.Controls.Add(Me.imgRoulette)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.imgTapisRoulette)
        Me.Name = "Form1"
        Me.Text = "Roulette du swag"
        CType(Me.imgRoulette, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTapisRoulette, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imgRoulette As PictureBox
    Friend WithEvents imgTapisRoulette As PictureBox
    Friend WithEvents txtMise As TextBox
    Friend WithEvents lblMise As Label
    Friend WithEvents btnAjout10 As Button
    Friend WithEvents btnRetrait10 As Button
    Friend WithEvents btnValiderMise As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Timer1 As Timer
End Class
