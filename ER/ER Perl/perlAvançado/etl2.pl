#!d:\perl\bin\perl -w
# --------------------------------------------------------------------
# Perl by example
# ETL
# by lufer
# Disciplina: ISI
# Exemplo URL:
# http://www.troubleshooters.com/codecorn/littperl/perlreg.htm
# http://buffalo.pm.org/talks/map_grep/
# Sebenta: pag.10
# --------------------------------------------------------------------

$t="ola   mundo ";
if($t =~ m/\s+/){	# $x=~ m/exp/	idêntico a  $x=~ /exp/
	print   "Existe 1 espaço\n";
}
else {
      	print   "Não Existe\n";
}

while($t =~ /([a-z]+)/ig){
	print "Word= ".uc($1)."\n";
}


#ATENÇÃO
$string="Clin";
if($string =~ /[Clinton|Bush|Reagan]/){   #[A|B|C] == [ABC]
	$office = "President";
  print $office;
}


#Memorizar com $1, $2, ..., $n

$x = "isto é um teste com 7 palavras";
if ($x =~ /^(.*)?([0-9]+)(.*)?/g){
	print "\nNúmero = " . $2;
}


#Substituição
#s/exp1/exp2/ig
$t = "Instituto P. Cávado e Ave";
$t =~ s/P\./Politécnico/ig;
print "\n$t!\n";

#split
#Divide uma string segundo uma ExpReg
#Ver: http://www.comp.leeds.ac.uk/Perl/split.html
@vals=();
open (F,"<dados.csv") or die $!;
while (<F>){
	next unless $_ =~ /\w/; 	# filtra linhas em branco
  #next unless /\w/;
	print "Lido= $_\n";
	@vals = split(/[\;\s\,]+/,$_);	# idêntico a split(/;/)
  foreach $x (@vals){
        	print "$x\n";
  }
  @vals=();
}


#Hash
%nomes=();
$nomes{1}="luis";
$nomes{2}="ole";
$key=3;
print "Não Existe\n" if ! (exists $nomes{$key});
print "Definida\n" if defined $nomes{$key};
print "Verdade\n" if $nomes{$key};


#Exercícios
#1- Contar a ocorrência de cada palavra num ficheiro
$t = "ola mundo ola mundo fixe ola fixe é o mundo";
while($t =~ /([a-z]+)/ig){
	#print "Word= ".uc($1)."\n";
        $nomes{$1}++;
}

foreach $k (keys %nomes){
	print "$k = $nomes{$k}\n";
}



# grep testa uma expressão regular num array...
# Exemplo:
# @myNames = ('Benfica', 'Porto', 'Braga', 'Vianense', 'Sporting', 'Guimarães');
# @grepNames = grep(/^B/, @myNames); 
# @grepNames fica com 'Benfica' e 'Braga'


# Mostra conteúdo de directoria
#
# @files = readdir (DIR); 
# foreach $fName (@files){
#	my $file = $fName;
#	print $file;
#	print "\n";
# }
# exit 1;


#grep
#@LIST = grep(EXPRESSION, @ARRAY);

@myNames = ('Jacob', 'Michael', 'Joshua', 'Matthew', 'Alexander', 'Andrew');
@grepNames = grep(/^A/, @myNames);

foreach $i (@grepNames){
	print "$i\n";
}

#-----------------------------------

#reutilização na própria expressão regular
$t="axaxa";
print "Ok" if $t=~/([a-c])x\1x\1/;


#Mostra o conteúdo dentro das tags HTML
while(<STDIN>){
	#if(/<([A-Z][A-Z0-9]*)\b[^>]*>(.*?)<\/\1>/i){
	if(/<([A-Z][A-Z0-9]*)>(.*?)<\/\1>/i){
		print "\U$1 - \L$2 - \U$1\n";
	}
	else
		print;
}

#-----------------------------------