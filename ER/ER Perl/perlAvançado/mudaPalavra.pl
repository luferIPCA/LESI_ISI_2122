# by Lufer & Sergio
# 
#----------------------------------------------------------------------
#!/usr/bin/perl

#use Defs;

if (@ARGV<4){
		print "\n";
		print "\n\t-----------------------------------------------\n";
		print "\tSINTAX = mudaPalavra antiga nova path ext";
		print "\n";
		print "\n\t-----------------------------------------------\n";
		exit;	
}

#----VALORES DOS ARGUMENTOS
@param = split(/ /,$ARGV);
$velha=$ARGV[0];
$nova=$ARGV[1];
$path=$ARGV[2];
$ext= $ARGV[3];

opendir(DIR, "./$path") || die "Não consigo abrir \.\/\/$path: $!";
@files = grep { /(\.$ext)/ && -f "./$path/$_" } readdir(DIR);
closedir DIR;

foreach (@files) {
	$f=$_;	
	open (FOUT,"> ./$path/$f.new") || warn "Nao consegui criar $f.new\n";
	open (FILE,"./$path/$f") || warn "File $f inexistente...\n";;
	while (<FILE>){
 		s/$velha/$nova/g;
		print FOUT $_;
	}
	close(FILE);
	close(FOUT);
	
	unlink "./$path/$f";
	rename ("./$path/$f.new",$f) || warn $!;
	print "./$path/$f - done. \n";
}
