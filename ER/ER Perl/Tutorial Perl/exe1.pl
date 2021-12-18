#!d:\perl\bin\perl -w
# --------------------------------------------------------------------
# Perl by example
# exemplos de Perl (1)
# by lufer
# Disciplina: ISI
# Docente: lufer
# --------------------------------------------------------------------


print "doing exe2.pl\n";
#do 'exe2.pl';
print "\n";

#-----------------------------------
#Variáveis
$x = 12;
$y = $x+1;
print "X=$y\n";



$str ="Viva o Benfica";
print "$str \n";

#-----------------------------------
#Arrays 
@arr = (1,"O Glorioso",3,"Benfica");
print "$arr[1]=$arr[3]\n";

$arr[1]="O Maior";
print "$arr[1]=$arr[3]\n";

#-------

@letras=('a'..'z');
$x=$letras[7];
print "\$x=$x\n";

#-------
($x,$y)=@letras[3,5];
print "\$x=$x \$y=$y\n";

@aux=@letras[2,5,13];
print "Length de aux=".@aux."\n";	#length de um array é dado pelo nome do array: @arr
print "Ultima posicao de aux=".$#aux."\n";	#última posição do array= @arr-1

@chars=(0..9,'a'..'z');
print sort(@chars);print "\n";
print sort({$b cmp $a} @chars);
#-----------------------------------
#Arrays associativos (Hash)
print "\n";

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
print "Mes 2=". $meses{2};
print "\n";
#----done;
