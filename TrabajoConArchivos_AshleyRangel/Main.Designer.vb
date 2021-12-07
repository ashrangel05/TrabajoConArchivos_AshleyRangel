<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Menus = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuAbrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuGuardarComo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.subMenuCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.subMenuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SeleccionarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.InsertarImagenDesdeArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlejarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VistaNormalMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlinearALaIzquierdaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlinearALaDerechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlinearAlCentroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlinearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarColorDeFondoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarFuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDG = New System.Windows.Forms.OpenFileDialog()
        Me.SaveDG = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.stBar = New System.Windows.Forms.StatusStrip()
        Me.stLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stLabelCaracteres = New System.Windows.Forms.ToolStripStatusLabel()
        Me.controlRTF = New System.Windows.Forms.RichTextBox()
        Me.tBar = New System.Windows.Forms.ToolStrip()
        Me.tsBtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnAbrir = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnGuardarComo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnCerrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnDeshacer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnCortar = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnCopiar = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnPegar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnIzquierda = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnCentrar = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnDerecha = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnFonts = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnColor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnZoom = New System.Windows.Forms.ToolStripSplitButton()
        Me.ZoomAcercarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomAlejarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.VistaNormal11ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.ColorDG = New System.Windows.Forms.ColorDialog()
        Me.FontDG = New System.Windows.Forms.FontDialog()
        Me.Menus.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.stBar.SuspendLayout()
        Me.tBar.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menus
        '
        Me.Menus.Dock = System.Windows.Forms.DockStyle.None
        Me.Menus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.VerToolStripMenuItem})
        Me.Menus.Location = New System.Drawing.Point(0, 0)
        Me.Menus.Name = "Menus"
        Me.Menus.Size = New System.Drawing.Size(800, 24)
        Me.Menus.TabIndex = 1
        Me.Menus.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.subMenuAbrir, Me.subMenuGuardar, Me.subMenuGuardarComo, Me.ToolStripSeparator1, Me.subMenuCerrar, Me.ToolStripSeparator2, Me.subMenuSalir})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'subMenuAbrir
        '
        Me.subMenuAbrir.Name = "subMenuAbrir"
        Me.subMenuAbrir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.subMenuAbrir.Size = New System.Drawing.Size(238, 22)
        Me.subMenuAbrir.Text = "Abrir"
        '
        'subMenuGuardar
        '
        Me.subMenuGuardar.Enabled = False
        Me.subMenuGuardar.Name = "subMenuGuardar"
        Me.subMenuGuardar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.subMenuGuardar.Size = New System.Drawing.Size(238, 22)
        Me.subMenuGuardar.Text = "Guardar"
        '
        'subMenuGuardarComo
        '
        Me.subMenuGuardarComo.Enabled = False
        Me.subMenuGuardarComo.Name = "subMenuGuardarComo"
        Me.subMenuGuardarComo.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.subMenuGuardarComo.Size = New System.Drawing.Size(238, 22)
        Me.subMenuGuardarComo.Text = "Guardar como"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(235, 6)
        '
        'subMenuCerrar
        '
        Me.subMenuCerrar.Enabled = False
        Me.subMenuCerrar.Name = "subMenuCerrar"
        Me.subMenuCerrar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.subMenuCerrar.Size = New System.Drawing.Size(238, 22)
        Me.subMenuCerrar.Text = "Cerrar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(235, 6)
        '
        'subMenuSalir
        '
        Me.subMenuSalir.Name = "subMenuSalir"
        Me.subMenuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.subMenuSalir.Size = New System.Drawing.Size(238, 22)
        Me.subMenuSalir.Text = "Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeshacerToolStripMenuItem, Me.ToolStripSeparator3, Me.CortarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.ToolStripSeparator4, Me.SeleccionarTodoToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.ToolStripSeparator5, Me.InsertarImagenDesdeArchivoToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.EditarToolStripMenuItem.Text = "Edición"
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.Enabled = False
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.DeshacerToolStripMenuItem.Text = "Deshacer"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(229, 6)
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Enabled = False
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.CortarToolStripMenuItem.Text = "Cortar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Enabled = False
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Enabled = False
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(229, 6)
        '
        'SeleccionarTodoToolStripMenuItem
        '
        Me.SeleccionarTodoToolStripMenuItem.Enabled = False
        Me.SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        Me.SeleccionarTodoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.SeleccionarTodoToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.SeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Enabled = False
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(229, 6)
        '
        'InsertarImagenDesdeArchivoToolStripMenuItem
        '
        Me.InsertarImagenDesdeArchivoToolStripMenuItem.Enabled = False
        Me.InsertarImagenDesdeArchivoToolStripMenuItem.Name = "InsertarImagenDesdeArchivoToolStripMenuItem"
        Me.InsertarImagenDesdeArchivoToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.InsertarImagenDesdeArchivoToolStripMenuItem.Text = "Insertar imagen desde archivo"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercarToolStripMenuItem, Me.AlejarToolStripMenuItem, Me.VistaNormalMenuItem, Me.AlinearALaIzquierdaToolStripMenuItem, Me.AlinearALaDerechaToolStripMenuItem, Me.AlinearAlCentroToolStripMenuItem, Me.AlinearToolStripMenuItem, Me.CambiarColorDeFondoToolStripMenuItem, Me.CambiarFuenteToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'AcercarToolStripMenuItem
        '
        Me.AcercarToolStripMenuItem.Name = "AcercarToolStripMenuItem"
        Me.AcercarToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AcercarToolStripMenuItem.Text = "Aumentar"
        '
        'AlejarToolStripMenuItem
        '
        Me.AlejarToolStripMenuItem.Name = "AlejarToolStripMenuItem"
        Me.AlejarToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AlejarToolStripMenuItem.Text = "Alejar"
        '
        'VistaNormalMenuItem
        '
        Me.VistaNormalMenuItem.Name = "VistaNormalMenuItem"
        Me.VistaNormalMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.VistaNormalMenuItem.Text = "Vista normal (1:1)"
        '
        'AlinearALaIzquierdaToolStripMenuItem
        '
        Me.AlinearALaIzquierdaToolStripMenuItem.Enabled = False
        Me.AlinearALaIzquierdaToolStripMenuItem.Name = "AlinearALaIzquierdaToolStripMenuItem"
        Me.AlinearALaIzquierdaToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AlinearALaIzquierdaToolStripMenuItem.Text = "Alinear a la izquierda"
        '
        'AlinearALaDerechaToolStripMenuItem
        '
        Me.AlinearALaDerechaToolStripMenuItem.Enabled = False
        Me.AlinearALaDerechaToolStripMenuItem.Name = "AlinearALaDerechaToolStripMenuItem"
        Me.AlinearALaDerechaToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AlinearALaDerechaToolStripMenuItem.Text = "Alinear a la derecha"
        '
        'AlinearAlCentroToolStripMenuItem
        '
        Me.AlinearAlCentroToolStripMenuItem.Enabled = False
        Me.AlinearAlCentroToolStripMenuItem.Name = "AlinearAlCentroToolStripMenuItem"
        Me.AlinearAlCentroToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AlinearAlCentroToolStripMenuItem.Text = "Alinear al centro"
        '
        'AlinearToolStripMenuItem
        '
        Me.AlinearToolStripMenuItem.Enabled = False
        Me.AlinearToolStripMenuItem.Name = "AlinearToolStripMenuItem"
        Me.AlinearToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AlinearToolStripMenuItem.Text = "Cambiar color de texto"
        '
        'CambiarColorDeFondoToolStripMenuItem
        '
        Me.CambiarColorDeFondoToolStripMenuItem.Enabled = False
        Me.CambiarColorDeFondoToolStripMenuItem.Name = "CambiarColorDeFondoToolStripMenuItem"
        Me.CambiarColorDeFondoToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.CambiarColorDeFondoToolStripMenuItem.Text = "Cambiar color de fondo"
        '
        'CambiarFuenteToolStripMenuItem
        '
        Me.CambiarFuenteToolStripMenuItem.Enabled = False
        Me.CambiarFuenteToolStripMenuItem.Name = "CambiarFuenteToolStripMenuItem"
        Me.CambiarFuenteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.CambiarFuenteToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.CambiarFuenteToolStripMenuItem.Text = "Cambiar fuente"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.stBar)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.controlRTF)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(800, 379)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(800, 450)
        Me.ToolStripContainer1.TabIndex = 5
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.Menus)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.tBar)
        '
        'stBar
        '
        Me.stBar.Dock = System.Windows.Forms.DockStyle.None
        Me.stBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stLabel, Me.stLabelCaracteres})
        Me.stBar.Location = New System.Drawing.Point(0, 0)
        Me.stBar.Name = "stBar"
        Me.stBar.Size = New System.Drawing.Size(800, 22)
        Me.stBar.TabIndex = 0
        '
        'stLabel
        '
        Me.stLabel.Name = "stLabel"
        Me.stLabel.Size = New System.Drawing.Size(32, 17)
        Me.stLabel.Text = "Listo"
        Me.stLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stLabelCaracteres
        '
        Me.stLabelCaracteres.AutoSize = False
        Me.stLabelCaracteres.Name = "stLabelCaracteres"
        Me.stLabelCaracteres.Size = New System.Drawing.Size(100, 17)
        Me.stLabelCaracteres.Text = "Caracteres: 0"
        Me.stLabelCaracteres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'controlRTF
        '
        Me.controlRTF.AcceptsTab = True
        Me.controlRTF.BackColor = System.Drawing.Color.White
        Me.controlRTF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.controlRTF.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.controlRTF.Location = New System.Drawing.Point(0, 0)
        Me.controlRTF.Name = "controlRTF"
        Me.controlRTF.ReadOnly = True
        Me.controlRTF.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.controlRTF.Size = New System.Drawing.Size(800, 379)
        Me.controlRTF.TabIndex = 0
        Me.controlRTF.Text = ""
        '
        'tBar
        '
        Me.tBar.Dock = System.Windows.Forms.DockStyle.None
        Me.tBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsBtnNuevo, Me.tsBtnAbrir, Me.tsBtnGuardar, Me.tsBtnGuardarComo, Me.ToolStripSeparator6, Me.tsBtnCerrar, Me.ToolStripSeparator7, Me.tsBtnSalir, Me.ToolStripSeparator8, Me.tsBtnDeshacer, Me.ToolStripSeparator14, Me.tsBtnCortar, Me.tsBtnCopiar, Me.tsBtnPegar, Me.ToolStripSeparator9, Me.tsBtnIzquierda, Me.tsBtnCentrar, Me.tsBtnDerecha, Me.ToolStripSeparator10, Me.tsBtnFonts, Me.tsBtnColor, Me.ToolStripSeparator11, Me.tsBtnZoom, Me.ToolStripSeparator13})
        Me.tBar.Location = New System.Drawing.Point(3, 24)
        Me.tBar.Name = "tBar"
        Me.tBar.Size = New System.Drawing.Size(428, 25)
        Me.tBar.TabIndex = 2
        '
        'tsBtnNuevo
        '
        Me.tsBtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnNuevo.Image = CType(resources.GetObject("tsBtnNuevo.Image"), System.Drawing.Image)
        Me.tsBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnNuevo.Name = "tsBtnNuevo"
        Me.tsBtnNuevo.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnNuevo.Text = "Nuevo documento"
        '
        'tsBtnAbrir
        '
        Me.tsBtnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnAbrir.Image = CType(resources.GetObject("tsBtnAbrir.Image"), System.Drawing.Image)
        Me.tsBtnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnAbrir.Name = "tsBtnAbrir"
        Me.tsBtnAbrir.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnAbrir.Text = "Abrir documento"
        '
        'tsBtnGuardar
        '
        Me.tsBtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnGuardar.Enabled = False
        Me.tsBtnGuardar.Image = CType(resources.GetObject("tsBtnGuardar.Image"), System.Drawing.Image)
        Me.tsBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnGuardar.Name = "tsBtnGuardar"
        Me.tsBtnGuardar.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnGuardar.Text = "Guardar"
        '
        'tsBtnGuardarComo
        '
        Me.tsBtnGuardarComo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnGuardarComo.Enabled = False
        Me.tsBtnGuardarComo.Image = CType(resources.GetObject("tsBtnGuardarComo.Image"), System.Drawing.Image)
        Me.tsBtnGuardarComo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnGuardarComo.Name = "tsBtnGuardarComo"
        Me.tsBtnGuardarComo.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnGuardarComo.Text = "Guardar como"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsBtnCerrar
        '
        Me.tsBtnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnCerrar.Enabled = False
        Me.tsBtnCerrar.Image = CType(resources.GetObject("tsBtnCerrar.Image"), System.Drawing.Image)
        Me.tsBtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnCerrar.Name = "tsBtnCerrar"
        Me.tsBtnCerrar.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnCerrar.Text = "Cerrar"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'tsBtnSalir
        '
        Me.tsBtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnSalir.Enabled = False
        Me.tsBtnSalir.Image = CType(resources.GetObject("tsBtnSalir.Image"), System.Drawing.Image)
        Me.tsBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnSalir.Name = "tsBtnSalir"
        Me.tsBtnSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnSalir.Text = "Salir"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'tsBtnDeshacer
        '
        Me.tsBtnDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnDeshacer.Enabled = False
        Me.tsBtnDeshacer.Image = CType(resources.GetObject("tsBtnDeshacer.Image"), System.Drawing.Image)
        Me.tsBtnDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnDeshacer.Name = "tsBtnDeshacer"
        Me.tsBtnDeshacer.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnDeshacer.Text = "Deshacer"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 25)
        '
        'tsBtnCortar
        '
        Me.tsBtnCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnCortar.Enabled = False
        Me.tsBtnCortar.Image = CType(resources.GetObject("tsBtnCortar.Image"), System.Drawing.Image)
        Me.tsBtnCortar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnCortar.Name = "tsBtnCortar"
        Me.tsBtnCortar.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnCortar.Text = "Cortar"
        '
        'tsBtnCopiar
        '
        Me.tsBtnCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnCopiar.Enabled = False
        Me.tsBtnCopiar.Image = CType(resources.GetObject("tsBtnCopiar.Image"), System.Drawing.Image)
        Me.tsBtnCopiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnCopiar.Name = "tsBtnCopiar"
        Me.tsBtnCopiar.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnCopiar.Text = "Copiar"
        '
        'tsBtnPegar
        '
        Me.tsBtnPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnPegar.Enabled = False
        Me.tsBtnPegar.Image = CType(resources.GetObject("tsBtnPegar.Image"), System.Drawing.Image)
        Me.tsBtnPegar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnPegar.Name = "tsBtnPegar"
        Me.tsBtnPegar.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnPegar.Text = "Pegar"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'tsBtnIzquierda
        '
        Me.tsBtnIzquierda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnIzquierda.Enabled = False
        Me.tsBtnIzquierda.Image = CType(resources.GetObject("tsBtnIzquierda.Image"), System.Drawing.Image)
        Me.tsBtnIzquierda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnIzquierda.Name = "tsBtnIzquierda"
        Me.tsBtnIzquierda.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnIzquierda.Text = "Alinear a la izquierda"
        '
        'tsBtnCentrar
        '
        Me.tsBtnCentrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnCentrar.Enabled = False
        Me.tsBtnCentrar.Image = CType(resources.GetObject("tsBtnCentrar.Image"), System.Drawing.Image)
        Me.tsBtnCentrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnCentrar.Name = "tsBtnCentrar"
        Me.tsBtnCentrar.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnCentrar.Text = "Alinear al centro"
        '
        'tsBtnDerecha
        '
        Me.tsBtnDerecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnDerecha.Enabled = False
        Me.tsBtnDerecha.Image = CType(resources.GetObject("tsBtnDerecha.Image"), System.Drawing.Image)
        Me.tsBtnDerecha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnDerecha.Name = "tsBtnDerecha"
        Me.tsBtnDerecha.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnDerecha.Text = "Alinear a la derecha"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'tsBtnFonts
        '
        Me.tsBtnFonts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnFonts.Enabled = False
        Me.tsBtnFonts.Image = CType(resources.GetObject("tsBtnFonts.Image"), System.Drawing.Image)
        Me.tsBtnFonts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnFonts.Name = "tsBtnFonts"
        Me.tsBtnFonts.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnFonts.Text = "Cambiar fuente"
        '
        'tsBtnColor
        '
        Me.tsBtnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnColor.Enabled = False
        Me.tsBtnColor.Image = CType(resources.GetObject("tsBtnColor.Image"), System.Drawing.Image)
        Me.tsBtnColor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnColor.Name = "tsBtnColor"
        Me.tsBtnColor.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnColor.Text = "CAmbiar color de fuente"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'tsBtnZoom
        '
        Me.tsBtnZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnZoom.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomAcercarToolStripMenuItem, Me.ZoomAlejarToolStripMenuItem, Me.ToolStripSeparator12, Me.VistaNormal11ToolStripMenuItem})
        Me.tsBtnZoom.Enabled = False
        Me.tsBtnZoom.Image = CType(resources.GetObject("tsBtnZoom.Image"), System.Drawing.Image)
        Me.tsBtnZoom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnZoom.Name = "tsBtnZoom"
        Me.tsBtnZoom.Size = New System.Drawing.Size(32, 22)
        Me.tsBtnZoom.Text = "Zoom"
        '
        'ZoomAcercarToolStripMenuItem
        '
        Me.ZoomAcercarToolStripMenuItem.Name = "ZoomAcercarToolStripMenuItem"
        Me.ZoomAcercarToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ZoomAcercarToolStripMenuItem.Text = "Acercar"
        '
        'ZoomAlejarToolStripMenuItem
        '
        Me.ZoomAlejarToolStripMenuItem.Name = "ZoomAlejarToolStripMenuItem"
        Me.ZoomAlejarToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ZoomAlejarToolStripMenuItem.Text = "Alejar"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(137, 6)
        '
        'VistaNormal11ToolStripMenuItem
        '
        Me.VistaNormal11ToolStripMenuItem.Name = "VistaNormal11ToolStripMenuItem"
        Me.VistaNormal11ToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.VistaNormal11ToolStripMenuItem.Text = "Vista normal"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(800, 425)
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(800, 450)
        Me.ToolStripContainer2.TabIndex = 2
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.ToolStripContainer2)
        Me.MainMenuStrip = Me.Menus
        Me.Name = "Main"
        Me.Text = "Amazing Editor v1.0"
        Me.Menus.ResumeLayout(False)
        Me.Menus.PerformLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.stBar.ResumeLayout(False)
        Me.stBar.PerformLayout()
        Me.tBar.ResumeLayout(False)
        Me.tBar.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Menus As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents subMenuAbrir As ToolStripMenuItem
    Friend WithEvents subMenuCerrar As ToolStripMenuItem
    Friend WithEvents subMenuGuardar As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents subMenuSalir As ToolStripMenuItem
    Friend WithEvents OpenDG As OpenFileDialog
    Friend WithEvents SaveDG As SaveFileDialog
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents subMenuGuardarComo As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertarImagenDesdeArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlejarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlinearALaIzquierdaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlinearALaDerechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlinearAlCentroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlinearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents CambiarColorDeFondoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarFuenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripContainer2 As ToolStripContainer
    Friend WithEvents stBar As StatusStrip
    Friend WithEvents controlRTF As RichTextBox
    Friend WithEvents tBar As ToolStrip
    Friend WithEvents stLabel As ToolStripStatusLabel
    Friend WithEvents stLabelCaracteres As ToolStripStatusLabel
    Friend WithEvents tsBtnNuevo As ToolStripButton
    Friend WithEvents tsBtnAbrir As ToolStripButton
    Friend WithEvents tsBtnGuardar As ToolStripButton
    Friend WithEvents tsBtnGuardarComo As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsBtnCerrar As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsBtnSalir As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents tsBtnCortar As ToolStripButton
    Friend WithEvents tsBtnCopiar As ToolStripButton
    Friend WithEvents tsBtnPegar As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents tsBtnIzquierda As ToolStripButton
    Friend WithEvents tsBtnCentrar As ToolStripButton
    Friend WithEvents tsBtnDerecha As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents tsBtnFonts As ToolStripButton
    Friend WithEvents tsBtnColor As ToolStripButton
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents tsBtnZoom As ToolStripSplitButton
    Friend WithEvents ZoomAcercarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomAlejarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents VistaNormal11ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents tsBtnDeshacer As ToolStripButton
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents ColorDG As ColorDialog
    Friend WithEvents FontDG As FontDialog
    Friend WithEvents VistaNormalMenuItem As ToolStripMenuItem
End Class
