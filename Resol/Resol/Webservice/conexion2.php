<?php 
    $bdcon=true;
	$conexion=new mysqli("localhost","id15185991_root","Progra-Movil2","id15185991_pw2_planilla");
	if($conexion->connect_errno)
	{
		$bdcon=false;
	}
	echo $bdcon;
?>