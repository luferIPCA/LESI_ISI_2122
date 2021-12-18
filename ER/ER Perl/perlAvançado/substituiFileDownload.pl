# by lufer
# Altera determinada palavra num ficheiro


#if (length($ARGV[0])==0){
if (@ARGV<3){
		print "\n";
		print "\n\t-----------------------------------------------\n";
		print "\tSINTAX = substituiFileDownload ano mes edicao ";
		print "\n";
		print "\tEx: substituiFileDownload 2000 jan 1\n";
		print "\n\t-----------------------------------------------\n";
		exit;	
}

# Qual o resultado?
while (<*.html>){
	print;
 }

#----VALORES DOS ARGUMENTOS
@param = split(//,$ARGV);
$ano=$ARGV[0];
$mes=$ARGV[1];
$edicao=$ARGV[2];
#$homePath="$ano\/$mes\/q$edicao";
$homePath=".";


opendir (DIR,"$homePath") || die "Directoria desconhecida $dirname: $!";

@files = grep {/\.html$/i} readdir (DIR); 
foreach $fName (@files){
	my $file = $fName;
	print $file;
	@n = split (/\./,$fName);						
	# ou ($nome,$ext)=split (/\./,$fName);	

	$f = "< $homePath/$file";
	$f1 = "> $homePath/$file.tmp";


	open (F,$f ) || warn "$! - $f";
	open (F1,$f1 ) || warn "$! - $f1";
	while (<F>){
		s/{fileDownload}/\<a href=\"\/$ano\/$mes\/$edicao\/sourcesrtf\/$n[0]\.zip\"\>$fName \<\/a\>/g;
		print F1 $_;
	}
	
	
	close(F);
	close(F1);
	
	unlink "$homePath/$file";
	
	rename ("$homePath/$file.tmp","$homePath/$file") || warn $!;
	print "- done\n";
}
closedir(DIR);

