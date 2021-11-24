<?php
include("conexion.php");
	if(!$bdcon)
	{
		echo "Lo sentimos, este sitio web esta experimentando problemas";
		exit;
	}
	else 
	{
		$datos=array();
		$sql="SELECT * FROM tbl_grado";
		$result=mysqli_query($conexion,$sql);
		while($row=mysqli_fetch_assoc($result))
		{
			array_push($datos,array(
				'gradoc'=>$row["grado_codigo"],
				'gradon'=>$row["grado_nombre"],
			));
		}
		echo utf8_encode(json_encode($datos));
	}
?>