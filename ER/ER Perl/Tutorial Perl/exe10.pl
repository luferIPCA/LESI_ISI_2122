#!d:\perl\bin\perl -w
# --------------------------------------------------------------------
# Perl by example
# exemplos de Perl (10)
# by lufer
# Expressões Regulares
# --------------------------------------------------------------------
# \w == [a-zA-Z0-9_]
# \W == complemento de \w == [^a-zA-Z0-9_]

$_ = "AAABBBccC";
$charList = "ADE";
print "matched\n" if m/[$charList]/;

#----------------

$_ = '/user/Jackie/temp/names.dat';
m/.*/;
print "$&\n";

#----------------

$_ =  "AAA BBB ccC";
m/(\w+)/;
print("E1: $1\n");

#----------------

$_ =  "AAA BBB ccC";

while (m/(\w+)/g) {
    print("E2:$1\n");
}

#----------------

$_ =  "AAA BBB ccC";
@matches = m/(\w+)/g;
print("@matches\n");


#----------------

#$+ - the value that the last bracket match matched.
#$& - string encontrada
#$` - everything in the searched string that is before the matched string.
#$' - everything in the search string that is after the matched string.

#----------------

while (<>) {
		chomp;
		last if (length($_)==0);
    push(@array, $&) if m/^\w+\(?=\s+Vet\)?/;
}

print("LIDO: @array\n");


m/^\s*(\w+)/;			#1ª palavra
m/^(\w+)\W+(\w+)$/x;		#só duas palavras
m/^\s*(\w+)\W+(\w+)\s*$/;	#só duas palavras ignorando espaços

#-----------------

$_ = "This is the way to San Jose.";
$word   = '\w+';    # match a whole word.
$space  = '\W+';    # match at least one character of whitespace
$string = '.*';     # match any number of anything except
                    # for the newline character.
($one, $two, $rest) = (m/^($word) $space ($word) $space ($string)/x);

#-----------------

s/^\s+//;			#remove espaços no início
s/\s+$//;			#remove espaços no fim

#-----------------
$prefix = "A";			#prefixo numa palavra
s/^(.*)/$prefix$1/;

$suffix = "Z";			#sufixo numa palavra
s/^(.*)/$1$suffix/;

#-----------------

s/^\s*(\w+)\W+(\w+)/$2 $1/;	#trocar a ordem
s/\w/$& x 2/eg;			#duplicar cada caracter numa string
s/(\w+)/\u$1/g;			#passa a maiusculas cada primeira letra

#-----------------

$line =~ s/^\s+//;		#separar palavras
@array = split(/\W/, $line);


@array = split(/:/);		#separado por :



