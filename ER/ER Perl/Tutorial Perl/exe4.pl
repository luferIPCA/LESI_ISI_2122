#!d:\perl\bin\perl -w
# --------------------------------------------------------------------
# Perl by example
# exemplos de Perl (4)
# by lufer
# --------------------------------------------------------------------

$aux="Benfica";
print (($aux lt "Porto") ? "M\xA0gico\n" : "Impossivel\n");

#-----------------------------------
$"=":";				#$" representa uma variável de ambiente
@array=('a'..'z');

print "@array\n";
#O que acontece se $" for "-"?

#-----------------------------------
$lowVar = "AAA";

$midVar = "BBB";

$hiVar  = "ccC";

print($lowVar cmp $midVar, "\n");

print($midVar cmp $midVar, "\n");

print($hiVar  cmp $midVar, "\n");

print ($hiVar  eq $midVar, "\n");

#-----------------------------------
#Qual o resultado de cada uma das seguintes operações?
#Mostre o resultado e um dos elementos à sua escolha;

@array1 = ("aa" .. "af");
@array2 = ("ay" .. "bf");

#-----------------------------------
#De que outra forma poderia fazer o mesmo que o seguinte código?

@array = ("Tom Jones", "123 Harley Lane", "Birmingham", "AR");

$name   = $array[0];
$street = $array[1];
$town   = $array[2];
$state  = $array[3];
print("$name, $street, $town, $state\n");

for($i=0; $i<=$#array;$i++)
{
		print "\$array[$i] = $array[$i]\n";
}

#($name, $street, $town, $state)=@array;

#print("$name, $street, $town, $state\n");
#-----------------------------------
