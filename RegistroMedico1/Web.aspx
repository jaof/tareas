<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Web.aspx.cs" Inherits="RegistroMedic.Web" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link  rel="stylesheet" type="text/scss" href="Margenes.scss" media="screen">
    <style type="text/css">
        .auto-style6 {
        width: 130px;
        color: #FF0000;
    }
        .auto-style11 {
            width: 228px;
            height: 23px;
        }
        .auto-style12 {
            width: 919px;
            height: 23px;
        }
        .auto-style14 {
            width: 228px;
            height: 26px;
        }
        .auto-style15 {
            width: 919px;
            height: 26px;
        }
        .auto-style17 {
            width: 228px;
            height: 32px;
        }
        .auto-style18 {
            width: 919px;
            height: 32px;
        }
        .auto-style19 {
            width: 541px;
            height: 23px;
        }
        .auto-style20 {
            width: 541px;
            height: 26px;
        }
        .auto-style22 {
            width: 541px;
            height: 32px;
        }
        .auto-style23 {
            width: 541px;
            height: 22px;
        }
        .auto-style24 {
            width: 228px;
            height: 22px;
        }
        .auto-style25 {
            width: 919px;
            height: 22px;
        }
        .auto-style26 {
            width: 541px;
            height: 33px;
        }
        .auto-style27 {
            width: 228px;
            height: 33px;
        }
        .auto-style28 {
            width: 919px;
            height: 33px;
        }
        .auto-style29 {
            width: 541px;
            height: 39px;
        }
        .auto-style30 {
            width: 228px;
            height: 39px;
        }
        .auto-style31 {
            width: 919px;
            height: 39px;
        }
        .auto-style35 {
            width: 541px;
            height: 51px;
        }
        .auto-style36 {
            width: 228px;
            height: 51px;
        }
        .auto-style37 {
            width: 919px;
            height: 51px;
        }
        .auto-style38 {
            width: 541px;
            height: 2px;
        }
        .auto-style39 {
            width: 228px;
            height: 2px;
        }
        .auto-style40 {
            width: 919px;
            height: 2px;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:43%; height: 375px;">
            <tr>
                <td class="auto-style19">IdPaciente</td>
                <td class="auto-style11">
                    <asp:TextBox ID="TextBoxIdPaciente" runat="server" Width="216px"></asp:TextBox>
                </td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style20">Nombres</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TextBoxNombre" runat="server" Width="219px"></asp:TextBox>
                </td>
                <td class="auto-style15">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxNombre" CssClass="auto-style6" ErrorMessage="Nombre No Puede Estar Vacio">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style22">Apellidos</td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBoxApellido" runat="server" Width="219px"></asp:TextBox>
                </td>
                <td class="auto-style18">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxApellido" CssClass="auto-style6" ErrorMessage="Apellido No Puede Estar Vacio" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">Direccion</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TextBoxDireccion" runat="server" Width="217px"></asp:TextBox>
                </td>
                <td class="auto-style15">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxDireccion" CssClass="auto-style6" ErrorMessage="Direccion No Puede Estar Vacio">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">Telefono</td>
                <td class="auto-style24">
                    <asp:TextBox ID="TextBoxTelefono" runat="server" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style25">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxTelefono" CssClass="auto-style6" ErrorMessage="Telefono No Puede Estar Vacio">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style26">Celular</td>
                <td class="auto-style27">
                    <asp:TextBox ID="TextBoxCelular" runat="server" Width="218px"></asp:TextBox>
                </td>
                <td class="auto-style28">
                    </td>
            </tr>
            <tr>
                <td class="auto-style26">Cedula</td>
                <td class="auto-style27">
                    <asp:TextBox ID="TextBoxCedula" runat="server" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style28">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBoxCedula" CssClass="auto-style6" ErrorMessage="Cedula No Puede Estar Vacio">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style22">Fecha Nacimiento</td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBoxFechaNac" runat="server" Width="215px" TextMode="Date"></asp:TextBox>
                </td>
                <td class="auto-style18">
                    </td>
            </tr>
            <tr>
                <td class="auto-style29">Fecha Salida</td>
                <td class="auto-style30">
                    <asp:TextBox ID="TextBoxFechaIng" runat="server" Width="215px" TextMode="Date"></asp:TextBox>
                </td>
                <td class="auto-style31">
                    </td>
            </tr>
            <tr>
                <td class="auto-style38">Sexo</td>
                <td class="auto-style39">
                    <asp:DropDownList ID="DropDownListSexo" runat="server" Width="133px" Height="33px">
                        <asp:ListItem Value="0">Femenino</asp:ListItem>
                        <asp:ListItem Value="1">Masculino</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style40">
                    </td>
            </tr>
            <tr>
                <td class="auto-style35">Ocupacion</td>
                <td class="auto-style36">
                    <asp:TextBox ID="TextBoxOcupacion" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style37">
                 
                </td>
            </tr>
        </table>
        <table>
        </table>
    
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" style="color: #FF0000" />
       

        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />
       <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
       

     
     
</asp:Content>
