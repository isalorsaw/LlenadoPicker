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
		$sql="select * from tbl_aniolec";
		$result=mysqli_query($conexion,$sql);
		while($row=mysqli_fetch_assoc($result))
		{
			array_push($datos,array(
				'anioc'=>$row["aniol_anio"],
				'anion'=>$row["aniol_anio"],
			));
		}
		echo utf8_encode(json_encode($datos));
	}
?>