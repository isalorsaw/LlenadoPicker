<?php 
    $bdcon=true;
	$conexion=new mysqli("localhost","id15185991_root","Progra-Movil2","id15185991_pw2_planilla");
	if($conexion->connect_errno)
	{
		echo "Lo sentimos, este sitio web esta experimentando problemas ".$mysqli -> error;
		//exit;
		$bdcon=false;
	}
	//else echo "Conexion Exitosa";
?>