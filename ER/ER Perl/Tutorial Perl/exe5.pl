#!d:\perl\bin\perl -w
# --------------------------------------------------------------------
# Perl by example
# exemplos de Perl (5)
# by lufer
# --------------------------------------------------------------------

show_nl ("Benfica");
show_nl ((1..9));

sub show_nl{
	
	print "@_\n";
}

#-----------------------------------
max (2,3);

sub max{
	($a,$b)=@_;
	print "Argumentos=".@_."\n";
	print (($a>$b) ? $a : $b);
}

#-----------------------------------
#Procure implementar as funções:
#potencia, e_par, somatorio de x elementos

#-----------------------------------
#Passagem de valores por referência
@array = (0..5);
print("Before function call, array = @array\n");

firstsub(@array);
print("After function call, array =  @array\n");

sub firstsub{

    $_[0] = "A";
    $_[1] = "B";
}


#-----------------------------------
#scope de variáveis 
#Qual o output do seguinte programa?  

firstSub("AAAAA", "BBBBB"); 

sub firstSub{

    local ($firstVar) = $_[0];
    my($secondVar)    = $_[1];

    print("firstSub: firstVar  = $firstVar\n");
    print("firstSub: secondVar = $secondVar\n\n");

    secondSub();

    print("firstSub: firstVar  = $firstVar\n");
    print("firstSub: secondVar = $secondVar\n\n");
}

sub secondSub{
    print("secondSub: firstVar  = $firstVar\n");
    print("secondSub: secondVar = $secondVar\n\n");

    $firstVar  = "ccccC";
    $secondVar = "DDDDD";

    print("secondSub: firstVar  = $firstVar\n");
    print("secondSub: secondVar = $secondVar\n\n");
}

#-----------------------------------
#Qual o output? Como resolvia o problema?

firstSub((0..10), "AAAA");

sub firstSub{

    local(@array, $firstVar) = @_ ;

    print("firstSub: array    = @array\n");
    print("firstSub: firstVar = $firstVar\n");
}

