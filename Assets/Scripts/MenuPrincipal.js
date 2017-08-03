#pragma strict

function Start () {
	
}

function Update () {
	
}
function OnGUI ()
{
   GUI.color = new Color(1,1,1,0.3f);
 if( GUI.Button(new Rect(302,250,125,30),""))
   {
	 Application.LoadLevel("MenuSeleccionarFase");
   }
  if( GUI.Button(new Rect(275,293,175,30),"") )
   {
	 Application.LoadLevel("EscenaJuego");
   }
    if( GUI.Button(new Rect(290,333,150,30),"") )
   {
	 Application.LoadLevel("MenuPrincipalColores");
   }

}