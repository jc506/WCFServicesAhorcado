<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AhorcadoCliente.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ahorcado</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">

</head>
<body>

    <div class="container">
        <div class="row m-auto">
            <div class="col-12">
                <form id="form1" runat="server">
                    <div>
                        <asp:Label ID="lblPalabraNueva" runat="server" Visible="False"></asp:Label>

                       <div class="alert alert-warning alert-dismissible fade show" role="alert">
                          <strong>Para iniciar el juego precione sobre la tecla nueva palabra!</strong>
                          <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
                        </div>
                        <br />
                        <asp:Button ID="btnPalabraNueva" CssClass="btn btn-primary text-center mt-3" runat="server" Text="Nueva Palabra" OnClick="btnPalabraNueva_Click" />
                        <br />
                        <br />
                        <br />
                        <asp:Label ID="Label1" Class="text-info fw-bold h5" runat="server" Text="Intentos Restantes: "></asp:Label>
                        <asp:Label ID="lblVidas" CssClass="btn btn-outline-warning" runat="server" Text="7"></asp:Label>
                        <br />
                        <br />
                        <br />
                        <asp:Label ID="lblPalabraNuevaGuion" CssClass="h3 " runat="server" Font-Bold="False" Font-Size="XX-Large" ForeColor="#0000CC"></asp:Label>
                        <br />
                        <br />
                        <br />
                        <asp:Label ID="lblMensaje" CssClass="text-success h2" runat="server"></asp:Label>
                    </div>
                    <br />
                    <br />
                    <br />
                    <p>
                        <asp:Image ID="Image1" runat="server" Height="210px" ImageUrl="~/Sources/images/hang7.jpg" Width="279px" />
                    </p>
                    
                    <p > 
                        <asp:Button ID="btnA" class="btn btn-secondary text-center" runat="server" OnClick="btn_Click" Text="A" Width="45px" />
                        <asp:Button ID="btnB" class="btn btn-secondary text-center" runat="server" OnClick="btn_Click" Text="B" Width="45px" />
                        <asp:Button ID="btnC" class="btn btn-secondary text-center" runat="server" OnClick="btn_Click" Text="C" Width="45px" />
                        <asp:Button ID="btnD" class="btn btn-secondary text-center" runat="server" Text="D" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnE" class="btn btn-secondary text-center" runat="server" OnClick="btn_Click" Text="E" Width="45px" />
                        <asp:Button ID="btnF" class="btn btn-secondary text-center" runat="server" Text="F" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnG" class="btn btn-secondary text-center" runat="server" Text="G" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnH" class="btn btn-secondary text-center" runat="server" Text="H" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnI" class="btn btn-secondary text-center" runat="server" Text="I" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnJ" class="btn btn-secondary text-center" runat="server" Text="J" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnK" class="btn btn-secondary text-center" runat="server" Text="K" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnL" class="btn btn-secondary text-center" runat="server" Text="L" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnM" class="btn btn-secondary text-center" runat="server" OnClick="btn_Click" Text="M" Width="45px" />
                        <asp:Button ID="btnN" class="btn btn-secondary text-center" runat="server" Text="N" OnClick="btn_Click" Width="45px" />
                  </p>
                    <p>
                        <asp:Button ID="btnO" class="btn btn-secondary text-center" runat="server" Text="O" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnP" class="btn btn-secondary text-center" runat="server" Text="P" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnQ" class="btn btn-secondary text-center" runat="server" Text="Q" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnR" class="btn btn-secondary text-center" runat="server" Text="R" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnS" class="btn btn-secondary text-center" runat="server" OnClick="btn_Click" Text="S" Width="45px" />
                        <asp:Button ID="btnT" class="btn btn-secondary text-center" runat="server" Text="T" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnU" class="btn btn-secondary text-center" runat="server" Text="U" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnV" class="btn btn-secondary text-center" runat="server" Text="V" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnW" class="btn btn-secondary text-center" runat="server" Text="W" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnX" class="btn btn-secondary text-center" runat="server" Text="X" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnY" class="btn btn-secondary text-center" runat="server" Text="Y" OnClick="btn_Click" Width="45px" />
                        <asp:Button ID="btnZ" class="btn btn-secondary text-center" runat="server" Text="Z" OnClick="btn_Click" Width="45px" />
                    </p>
                </form>
            </div>
        </div>
    </div>

   

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
  
</body>
</html>
