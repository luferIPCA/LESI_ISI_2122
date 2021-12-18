#!d:\perl\bin\perl -w
# --------------------------------------------------------------------
# Perl by example
# exemplos de Perl (8)
# by lufer
# Ficheiros
# --------------------------------------------------------------------

# $f=<>;

while(<>){
	while (/^Quando/gm){
		print $.;
	}
	print;
}


while (<STDIN>) {

    print();

}


#-----------------------------------
foreach (@ARGV) {

    print;

    print((-f) ? " -Normal\n" : " -Directoria\n")	#testa $_

}
#exit();
#-----------------------------------
foreach (@ARGV) {

    next unless -f;    # ignora os directorias

    print;

    print((-f) ? " -Normal\n" : " -Directoria\n")	#testa $_

}
#O que acontece com o seguinte comando
# perl exe8.pl \perl perl.exe \windows


#-----------------------------------

$INPUT_FILE = "exe6.pl";

open(INPUT_FILE);
@array = <INPUT_FILE>;
close(INPUT_FILE);

foreach (@array) {
    print();
}

#-----------------------------------
if (open(LOGFILE, ">message.log")) {

    print LOGFILE ("This is message number 1.\n");

    print LOGFILE ("This is message number 2.\n");

    close(LOGFILE);
}

#-----------------------------------
opendir(DIR, ".");

@files = sort(grep(/pl$/, readdir(DIR)));

closedir(DIR);

foreach (@files) {
    print("$_\n") unless -d;
}


