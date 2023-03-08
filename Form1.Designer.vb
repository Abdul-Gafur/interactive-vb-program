<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class btnresult
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(btnresult))
        Me.lblmaths = New System.Windows.Forms.Label()
        Me.lblenglish = New System.Windows.Forms.Label()
        Me.lblscience = New System.Windows.Forms.Label()
        Me.txtmaths = New System.Windows.Forms.TextBox()
        Me.txtenglish = New System.Windows.Forms.TextBox()
        Me.txtscience = New System.Windows.Forms.TextBox()
        Me.btnaverage = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btntotal = New System.Windows.Forms.Button()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblsocial = New System.Windows.Forms.Label()
        Me.txtsocial = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblmaths
        '
        resources.ApplyResources(Me.lblmaths, "lblmaths")
        Me.lblmaths.Name = "lblmaths"
        '
        'lblenglish
        '
        resources.ApplyResources(Me.lblenglish, "lblenglish")
        Me.lblenglish.Name = "lblenglish"
        '
        'lblscience
        '
        resources.ApplyResources(Me.lblscience, "lblscience")
        Me.lblscience.Name = "lblscience"
        '
        'txtmaths
        '
        resources.ApplyResources(Me.txtmaths, "txtmaths")
        Me.txtmaths.Name = "txtmaths"
        '
        'txtenglish
        '
        resources.ApplyResources(Me.txtenglish, "txtenglish")
        Me.txtenglish.Name = "txtenglish"
        '
        'txtscience
        '
        resources.ApplyResources(Me.txtscience, "txtscience")
        Me.txtscience.Name = "txtscience"
        '
        'btnaverage
        '
        resources.ApplyResources(Me.btnaverage, "btnaverage")
        Me.btnaverage.Name = "btnaverage"
        Me.btnaverage.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Yes
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btntotal
        '
        resources.ApplyResources(Me.btntotal, "btntotal")
        Me.btntotal.Name = "btntotal"
        Me.btntotal.UseVisualStyleBackColor = True
        '
        'lblresult
        '
        Me.lblresult.AutoEllipsis = True
        resources.ApplyResources(Me.lblresult, "lblresult")
        Me.lblresult.Name = "lblresult"
        Me.lblresult.UseMnemonic = False
        '
        'btnreset
        '
        resources.ApplyResources(Me.btnreset, "btnreset")
        Me.btnreset.Name = "btnreset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'lblsocial
        '
        resources.ApplyResources(Me.lblsocial, "lblsocial")
        Me.lblsocial.Name = "lblsocial"
        '
        'txtsocial
        '
        resources.ApplyResources(Me.txtsocial, "txtsocial")
        Me.txtsocial.Name = "txtsocial"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {resources.GetString("ComboBox1.Items"), resources.GetString("ComboBox1.Items1"), resources.GetString("ComboBox1.Items2"), resources.GetString("ComboBox1.Items3"), resources.GetString("ComboBox1.Items4")})
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.Name = "ComboBox1"
        '
        'btnresult
        '
        Me.AcceptButton = Me.Button3
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.btntotal)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnaverage)
        Me.Controls.Add(Me.txtsocial)
        Me.Controls.Add(Me.txtscience)
        Me.Controls.Add(Me.txtenglish)
        Me.Controls.Add(Me.txtmaths)
        Me.Controls.Add(Me.lblsocial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblscience)
        Me.Controls.Add(Me.lblenglish)
        Me.Controls.Add(Me.lblmaths)
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.Name = "btnresult"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblmaths As Label
    Friend WithEvents lblenglish As Label
    Friend WithEvents lblscience As Label
    Friend WithEvents txtmaths As TextBox
    Friend WithEvents txtenglish As TextBox
    Friend WithEvents txtscience As TextBox
    Friend WithEvents btnaverage As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btntotal As Button
    Friend WithEvents lblresult As Label
    Friend WithEvents btnreset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblsocial As Label
    Friend WithEvents txtsocial As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
