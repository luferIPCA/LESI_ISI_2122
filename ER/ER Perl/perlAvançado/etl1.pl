#by lufer
#EST-IPCA

#!/usr/local/bin/perl -w

# Tutorial On-Line: http://www.comp.leeds.ac.uk/Perl/start.html
  
print "\n\nContinuando no perl...(4) - Express. Regulares\n\n";

# -----------------------------------------------------------------------------------------------------------
# Procurar express�es (I)

$_="Viva o Porto...certamente o maior";
if (/Porto/){
	print "Tadinho..:\n";
}

#ou
print "Tadinho..:\n" if /Porto/;

# -----------------------------------------------------------------------------------------------------------
# Procurar e Susbtituir express�es (I)
# =~ operador binding
# var =~ s/../../
# var =~ m/../
# var =~ tr/../../

$t = "Viva o Porto...certamente o maior\n";
$t =~ s/Porto/Benfica/ig;
print $t;

#outra
$_="Viva o Porto...certamente o maior\n";
s/Porto/Benfica/ig;
#ou $_=~s/Porto/Benfica/ig;
print;

#outra
$t="Viva o Porto...certamente o maior\n";
if (!($t =~ m/Porto/)){					# nega��o: !~
	print "Tadinho..:\n";
}

# -----------------------------------------------------------------------------------------------------------
# Procurar e Susbtituir express�es (II)

$scalar = "O Benfica incomoda muita gente";
$match= $scalar =~ m/Benfica/;
$scalar	=~ s/muita/muitissima/;
$scalar =~ tr/a/A/;

print("\$match        = $match\n");
print("\$scalar       = $scalar\n");

$scalar =~ tr/[a-z]/[A-Z]/;
print("\$SCALAR       = $scalar\n");				# qual o resultado?

# -----------------------------------------------------------------------------------------------------------
# Analisar
# if($string =~ /[Clinton|Bush|Reagan]/){$office = "President"}



# -------------------------------------------------------------------------------------------
# Exerc�cios:
# 1 - Definir as seguintes express�es Regulares para:
#
# Telefones do tipo (+351) 253 802260 ou 253-802260
#
# Endere�os de email: 	xxxx.yyyy@zzzz.ww
#
# Passwords: 8 caracteres. S� pode ter letras e digitos.
#
# 2 -
# Contar as ocorr�ncias de uma palavra num ficheiro.
# Substituir todas as ocorr�ncias de uma palavra num ficheiro, por outra.
# Mudar o nome aos ficheiros com um determinado prefixo.
# Extrair para um ficheiro todas as frases que contenham determinada palavra


$_="BI : 12345678; Nome : lufer";

if ( m/BI\s*\:\s*([0-9]{8})\;\s*[a-zA-Z]*\s*:\s*([a-zA-Z ]*)/){
	$bi=$1;
	$nome=$2;
	print "BI : $bi e Nome: $nome";
}



if ( m/BI(\s*)\:(\s*)([0-9]{8})/){
	$bi=$3;
	print "BI$1:$2$bi";
}


