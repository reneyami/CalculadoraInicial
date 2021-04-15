<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculadora))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.lblSubtitulo2 = New System.Windows.Forms.Label()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnMultplicar = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnPotencia = New System.Windows.Forms.Button()
        Me.txtNumero1 = New System.Windows.Forms.TextBox()
        Me.txtNumero2 = New System.Windows.Forms.TextBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.lblResultadoNum = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.lblPrefecha = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblNombreAutor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        resources.ApplyResources(Me.lblTitulo, "lblTitulo")
        Me.lblTitulo.Name = "lblTitulo"
        '
        'lblSubtitulo
        '
        resources.ApplyResources(Me.lblSubtitulo, "lblSubtitulo")
        Me.lblSubtitulo.Name = "lblSubtitulo"
        '
        'lblSubtitulo2
        '
        resources.ApplyResources(Me.lblSubtitulo2, "lblSubtitulo2")
        Me.lblSubtitulo2.Name = "lblSubtitulo2"
        '
        'btnSuma
        '
        resources.ApplyResources(Me.btnSuma, "btnSuma")
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        resources.ApplyResources(Me.btnResta, "btnResta")
        Me.btnResta.Name = "btnResta"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnMultplicar
        '
        resources.ApplyResources(Me.btnMultplicar, "btnMultplicar")
        Me.btnMultplicar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMultplicar.Name = "btnMultplicar"
        Me.btnMultplicar.TabStop = False
        Me.btnMultplicar.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        resources.ApplyResources(Me.btnDivision, "btnDivision")
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnPotencia
        '
        resources.ApplyResources(Me.btnPotencia, "btnPotencia")
        Me.btnPotencia.Name = "btnPotencia"
        Me.btnPotencia.UseVisualStyleBackColor = True
        '
        'txtNumero1
        '
        resources.ApplyResources(Me.txtNumero1, "txtNumero1")
        Me.txtNumero1.Name = "txtNumero1"
        '
        'txtNumero2
        '
        resources.ApplyResources(Me.txtNumero2, "txtNumero2")
        Me.txtNumero2.Name = "txtNumero2"
        '
        'lblResultado
        '
        resources.ApplyResources(Me.lblResultado, "lblResultado")
        Me.lblResultado.Name = "lblResultado"
        '
        'lblResultadoNum
        '
        resources.ApplyResources(Me.lblResultadoNum, "lblResultadoNum")
        Me.lblResultadoNum.Name = "lblResultadoNum"
        '
        'txtResultado
        '
        resources.ApplyResources(Me.txtResultado, "txtResultado")
        Me.txtResultado.Name = "txtResultado"
        '
        'lblPrefecha
        '
        resources.ApplyResources(Me.lblPrefecha, "lblPrefecha")
        Me.lblPrefecha.Name = "lblPrefecha"
        '
        'lblFecha
        '
        resources.ApplyResources(Me.lblFecha, "lblFecha")
        Me.lblFecha.Name = "lblFecha"
        '
        'lblNombreAutor
        '
        resources.ApplyResources(Me.lblNombreAutor, "lblNombreAutor")
        Me.lblNombreAutor.Name = "lblNombreAutor"
        '
        'Calculadora
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.lblNombreAutor)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblPrefecha)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.lblResultadoNum)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.txtNumero2)
        Me.Controls.Add(Me.txtNumero1)
        Me.Controls.Add(Me.btnPotencia)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnMultplicar)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.lblSubtitulo2)
        Me.Controls.Add(Me.lblSubtitulo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSubtitulo As Label
    Friend WithEvents lblSubtitulo2 As Label
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnMultplicar As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnPotencia As Button
    Friend WithEvents txtNumero1 As TextBox
    Friend WithEvents txtNumero2 As TextBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents lblResultadoNum As Label
    Friend WithEvents lblPrefecha As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblNombreAutor As Label
End Class
