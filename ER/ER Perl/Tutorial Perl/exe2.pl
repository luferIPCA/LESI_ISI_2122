
#!d:\perl\bin\perl -w
# --------------------------------------------------------------------
# Perl by example: 
# exercício de Perl (2)
# Manipular Arrays
# by lufer
# --------------------------------------------------------------------
print "in exe2...";

@array = ("Tom Jones", "123 Harley Lane", "Birmingham", "AR");

$name   = $array[0];
$street = $array[1];
$town   = $array[2];
$state  = $array[3];
print("$name, $street, $town, $state\n");

#mostrar array
for($i=0; $i<=$#array;$i++)
{
		print "\$array[$i] = $array[$i]\n";
}

$i=0;
while($i<$#array){
	print "\$array[$i] = $array[$i]\n";
	$i++;
}

print ("\nORDENAR ARRAYS\n");

#array ordenado

push (@array,"Novo");	#adicionar  mais um elemento no final
#mostrar
print "Antes\n";
$i=0;
foreach $x (sort (@array)){
	print "\$array[$i] = $x\n";
	$i++;
}

pop(@array);	#remove última posição do array
#mostrar
print "Depois\n";
$i=0;
foreach $x (sort (@array)){
	print "\$array[$i] = $x\n";
	$i++;
}

$i=0;
foreach $x (sort (@array)){
	print "\$array[$i] = $x\n";
	$i++;
}

foreach $x (@array) {
	push(@array,  "\L$x");
}
#minusculas
foreach $x (sort (@array)){
	print "\$array[$i] = $x\n";
	$i++;
}

