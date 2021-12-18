#!d:\perl\bin\perl -w
# --------------------------------------------------------------------
# Perl by example
# by lufer
# --------------------------------------------------------------------
# comentários;
# instruções terminam em ;
# espaços, tabs não "contam"
# para executar, fazer "perl nome_ficheiro.pl"
#
# URL: http://www.tizag.com/perlT/index.php


# Genéricos

print("Ora Viva....\n");

#exit();


print("Uma primeira string...,\n", "Uma segunda string numa nova linha\n");

#print 'dir *.*';
#print "dir *.*";
#print `dir *.*`;
#print `hostname`;


#exit();

# Tipos de Dados

# scalar, arrays, arrays associativos

# scalar: numeric, strings, boolean
# símbolo: $
# exemplos:

	$n =12.3;
	$s = "Benfica";
	$b = 0;
	$b = $b+1;
	$b++;
	
	($a,$b) = (12,"ok");	#$a tem 12; $b tem "ok"
	
	($a,$b) = ($b,$a);	#troca conteúdos de a e b
	
	#print ("O valor de \$a e: $a - $b - $s - $n\n");
	

# exit();

# ARRAYS:
# símbolo: @
# exemplos:

	@dias=("seg","ter","qua","qui","sex","sab","dom");

	print $dias[2];
	
	
	foreach $i (@dias) { print "$i \n";}
	
	print "\n#-----------------------#\n";	

	@emptyArray = ();

	@numberArray = (12, 014, 0x0c, 34.34, 23.3E-3);

	@stringArray = ("This", "is", 'an', "array", 'of', "strings");

	@mixedArray = ("This", 30, "is", 'a', "mixed array", 'of', 0x08, "items");

	print "Here is an empty array:" . @emptyArray . "<- Nothing there!\n";

	print @numberArray;  print "\n";

	print @stringArray;  print "\n";

	print @mixedArray;   print "\n";
	
	#exit();

	print "\n#-----------------------#\n";

	@smallArrayOne = (5..10);

	@smallArrayTwo = (1..5);

	@largeArray = (@smallArrayOne, @smallArrayTwo);
	

	print @largeArray;
	
	#exit();

	print "\n#-----------------------#\n";
	
	
	@array = (1..5);

	print "@array\n";

	print $array[0];  
	
	print "\n";

	print "$array[4]\n";
	
	$index = 2;

	print "\$array[\$index] = $array[$index]\n";
	
	print "\$array[-1] = $array[-1]\n";

	print "$array[-2]\n";
	
	#exit();

	
	print "\n#-----------------------#\n";
	
	$numberOfElements = @array;

#	$doubleTheSize = 2 * @array;

	print "Total de elementos do Arrays: " . $numberOfElements . "\n";
	print "Ultima posicao do Array: " . $#array . "\n";
	
	
	print "\n#-----------------------#\n";
	
	@b=@array;	#atribuição de arrays
	
	$" = ",";	#formata o output

	print "@b\n";
	
	
	print "\n#-----------------------#\n";
	

	#exit();

	@array           = ("One", "Two", "Three", "Four");

	($first, $third) = @array[0, 2];

	@half            = @array[2, 3];


	print("\@array=@array\n");

	print("\$first=$first  \$third=$third\n");

	print("\@half=@half\n");

	@array[0, 3] = @array[3, 0];

	print("\@array=@array\n");


	#exit;

# arrays associativos: hashs
# símbolo: %
# exemplos:

	print "\n#-----------------------#\n";
	
	%associativeArray = ("Jack A.", "Dec 2", "Joe B.", "June 2", "Jane C.", "Feb 13");

	$associativeArray{"Jennifer S."} = "Mar 20";

	print "Joe's birthday is: " . $associativeArray{"Joe B."} . "\n";

	print "Jennifer's birthday is: " . $associativeArray{"Jennifer S."} . "\n";


	print "\n#-----------------------#\n";
	
	%dias=( 1 => "seg",2 => "ter", 3 => "qua", 4 => "qui", 5 => "sex", 6 => "sab", 7 => "dom");
	
	print $dias{6};
	
	foreach $i (keys (%dias)) { print "$i - $dias{$i}\n";}






#exit;

# EXERCÍCIOS

#-----------------------------------
print "doing exe2.pl\n";
do 'exe2.pl';
print "\n";

#-----------------------------------
#Arrays 
@letras=('a'..'z');
$x=$letras[7];
print "\$x=$x\n";

($x,$y)=@letras[3,5];
print "\$x=$x \$y=$y\n";

@aux=@letras[2,5,13];
print @aux;print "\n";

#-----------------------------------
#Arrays associativos
print "\n";

#-----------------------------------
%meses=(
	'jan'=>1,
	'fev'=>2,
	);
print $meses{'jan'};
print "\n";

#-----------------------------------
@semana{'jan','fev','mar'}=(1,2,3);

print $semana{'jan'};
print "\n";
#-----------------------------------
%meses=(
	1=>'jan',
	2=>'fev',
	);
print $meses{2};
print "\n";

