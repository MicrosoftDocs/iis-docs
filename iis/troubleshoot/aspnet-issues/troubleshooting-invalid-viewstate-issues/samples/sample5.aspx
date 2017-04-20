<%@ language=c# debug=true %> 
<script runat=server> 
protected override object LoadPageStateFromPersistenceMedium() 
{ 
     return Session["_ViewState"]; 
}
 
protected override void SavePageStateToPersistenceMedium(object viewState) 
{ 
     Session["_ViewState"] = viewState; 
}
 
void TextChanged(object o, EventArgs e) 
{ 
     Response.Write("TextChanged"); 
} 
</script> 
<form runat=server> 
<asp:button text=Test runat=server/> 
<asp:textbox ontextchanged=TextChanged runat=server/> 
<input type=hidden name=__VIEWSTATE> 
</form>