#!d:\perl\bin\perl -w
# --------------------------------------------------------------------
# Perl by example
# Manipula��o de Express�es Regulares com Perl
# by lufer
# Disciplina: ISI
# --------------------------------------------------------------------


$t="1234 - Passos Dias Aguiar Mota";

#Comparar strings

#if ($t =~ m/1234/){ print "Ok\n";}
#else	{print ("Not OK\n");}

#if ($t =~ /^1234/){ print "numeros no in�cio\n";}

#if ($t =~ m/^[0-9]{4}/){ print "Classe de numeros no in�cio\n";}

#if ($t !~ /^124/) { print "Numeros no in�cio errado\n";}

#$_=$t;
#if (/\s*([0-9]*)(.*)?([ a-zA-Z]*)$/){		#uso de $_
#	print "N�mero=$1 \n";
#	print "Nome=$2\n";
#}


#Substitui��o

$t= "O Porto � o maior, seguramente";
#$t1=$t;
#$t1 =~ s/Porto/Benfica/;
#print "Certo: $t1\n";



#Tradu��o
#while (<STDIN>){
#$t =~ tr/[a-z]/[A-Z]/;
#print $t;
#}
#print "Mai�sculas: $t\n";


#Exemplo
#$scalar = "A arvore tem varias folhas";
#print("String n�o tem a palavra arvore.\n") if $scalar !~ m/arvore/;	#negar =~
#$scalar =~ s/arvore/raiz/;
#$scalar =~ tr/h/H/;
#print("\$scalar = $scalar\n");



#Pattern Matching

#Separar string
#$t="O Porto � o maior, seguramente";
#$t =~ s/^\s+//;								#Elimina espa�os no �n�cio
#@array = split(/\,/, $t);			#separa as duas palavras entre v�rgulas
#foreach $s (@array){
#	print ("$s\n");
#}

#$t="23-11-2011";							# separador = "-"
#($d,$m,$a) = split("\-",$t);

#print" Dia = $d - Mes= $m - Ano= $a\n";


#procurar palavra em ficheiro

#$target="Benfica";
#open(INPUT, "<dados.txt");
#while (<INPUT>) {
#		 chomp;
#     if (/$target/i) {
#         print "Encontrei $target na linha $.\n";
#     }
#}
#close(INPUT);


#Colocar palavra em relevo num ficheiro HTML
#$+ - the value that the last bracket match matched.
#$& - string encontrada
#$` - everything in the searched string that is before the matched string.
#$' - everything in the search string that is after the matched string.
#$_

$target="IPCA";
open(INPUT, "<index.htm");
while (<INPUT>) {
		 chomp;
     if (/$target/i) {
         print $`."<b>$&</b>".$';
     }
     else { print;}
}
close(INPUT);