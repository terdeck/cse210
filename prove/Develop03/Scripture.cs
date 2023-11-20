using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
// one for the scripture itself

public class Scripture
{
private string _reference;
private string _text; //words hidden?
private int _scriptIndex;
private List<string> _scriptureList = new()
// delete book and verse number, scriptureList only contains text from verse
{
    // "Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.",
    "No man can serve two masters: for either he will hate the one, and love the other; or else he will hold to the one, and despise the other. Ye cannot serve God and mammon.",
    // "He saith unto them, But whom say ye that I am? And Simon Peter answered and said, Thou art the Christ, the Son of the living God. And Jesus answered and said unto him, Blessed art thou, Simon Bar-jona: for flesh and blood hath not revealed it unto thee, but my Father which is in heaven. And I say also unto thee, That thou art Peter, and upon this rock I will build my church; and the gates of hell shall not prevail against it. And I will give unto thee the keys of the kingdom of heaven: and whatsoever thou shalt bind on earth shall be bound in heaven: and whatsoever thou shalt loose on earth shall be loosed in heaven.",
    "And the King shall answer and say unto them, Verily I say unto you, Inasmuch as ye have done it unto one of the least of these my brethren, ye have done it unto me.",
    // "And as they thus spake, Jesus himself stood in the midst of them, and saith unto them, Peace be unto you. But they were terrified and affrighted, and supposed that they had seen a spirit. And he said unto them, Why are ye troubled? and why do thoughts arise in your hearts? Behold my hands and my feet, that it is I myself: handle me, and see; for a spirit hath not flesh and bones, as ye see me have.",
    "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.",
    "If any man will do his will, he shall know of the doctrine, whether it be of God, or whether I speak of myself.",
    "And other sheep I have, which are not of this fold: them also I must bring, and they shall hear my voice; and there shall be one fold, and one shepherd.",
    "If ye love me, keep my commandments.",
    "And this is life eternal, that they might know thee the only true God, and Jesus Christ, whom thou hast sent.",
    // "But he, being full of the Holy Ghost, looked up steadfastly into heaven, and saw the glory of God, and Jesus standing on the right hand of God, And said, Behold, I see the heavens opened, and the Son of man standing on the right hand of God.",
    "For I am not ashamed of the gospel of Christ: for it is the power of God unto salvation to every one that believeth; to the Jew first, and also to the Greek.",
    "There hath no temptation taken you but such as is common to man: but God is faithful, who will not suffer you to be tempted above that ye are able; but will with the temptation also make a way to escape, that ye may be able to bear it.",
    // "But now is Christ risen from the dead, and become the firstfruits of them that slept. For since by man came death, by man came also the resurrection of the dead. For as in Adam all die, even so in Christ shall all be made alive.",
    "Else what shall they do which are baptized for the dead, if the dead rise not at all? why are they then baptized for the dead?",
    // "There are also celestial bodies, and bodies terrestrial: but the glory of the celestial is one, and the glory of the terrestrial is another. There is one glory of the sun, and another glory of the moon, and another glory of the stars: for one star differeth from another star in glory. So also is the resurrection of the dead. It is sown in corruption; it is raised in incorruption:",
    // "And he gave some, apostles; and some, prophets; and some, evangelists; and some, pastors and teachers; For the perfecting of the saints, for the work of the ministry, for the edifying of the body of Christ: Till we all come in the unity of the faith, and of the knowledge of the Son of God, unto a perfect man, unto the measure of the stature of the fulness of Christ: That we henceforth be no more children, tossed to and fro, and carried about with every wind of doctrine, by the sleight of men, and cunning craftiness, whereby they lie in wait to deceive;",
    // "Now we beseech you, brethren, by the coming of our Lord Jesus Christ, and by our gathering together unto him, That ye be not soon shaken in mind, or be troubled, neither by spirit, nor by word, nor by letter as from us, as that the day of Christ is at hand. Let no man deceive you by any means: for that day shall not come, except there come a falling away first, and that man of sin be revealed, the son of perdition;",
    // "This know also, that in the last days perilous times shall come. For men shall be lovers of their own selves, covetous, boasters, proud, blasphemers, disobedient to parents, unthankful, unholy, Without natural affection, trucebreakers, false accusers, incontinent, fierce, despisers of those that are good, Traitors, heady, highminded, lovers of pleasures more than lovers of God; Having a form of godliness, but denying the power thereof: from such turn away.",
    // "All scripture is given by inspiration of God, and is profitable for doctrine, for reproof, for correction, for instruction in righteousness: That the man of God may be perfect, throughly furnished unto all good works.",
    "And no man taketh this honour unto himself, but he that is called of God, as was Aaron.",
    "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.",
    // "Even so faith, if it hath not works, is dead, being alone. Yea, a man may say, Thou hast faith, and I have works: shew me thy faith without thy works, and I will shew thee my faith by my works.",
    // "And I saw another angel fly in the midst of heaven, having the everlasting gospel to preach unto them that dwell on the earth, and to every nation, and kindred, and tongue, and people, Saying with a loud voice, Fear God, and give glory to him; for the hour of his judgment is come: and worship him that made heaven, and earth, and the sea, and the fountains of waters.",
    // "And I saw the dead, small and great, stand before God; and the books were opened: and another book was opened, which is the book of life: and the dead were judged out of those things which were written in the books, according to their works. And the sea gave up the dead which were in it; and death and hell delivered up the dead which were in them: and they were judged every man according to their works.",
};
    private Reference referenceNum = new();


    public string ChooseScripture()
    {
        // random function to choose a scripture
        Random randomGenerate = new Random();
        int index = randomGenerate.Next(_scriptureList.Count);
        return _scriptureList[index];
    }


    public void DisplayScripture()
    {
        // call Reference.DisplayReference()
        // add text
        // _reference = referenceNum.DisplayReference();
        // // string _scriptIndex = Scripture.ChooseScripture();
        // string _scriptureList = ChooseScripture();
        // _scriptureList[index];
        _scriptureList = ChooseScripture();
        _reference = Reference.DisplayReference(index);
        // Console.WriteLine($"{_reference} {_scriptureList}");
        Console.Write($" {_scriptureList} \n");
    }

    public void HideWords()
    // public HideWords(numberToHide: int) return void
        // random generator, choose 3 rando nums, pass that number/word to Words class, word will return underscores
    {
        // len _scriptureList 
        for (int i=0; i>3; i++);
        Random hide = new Random();
        string[] words = _scriptureList.Split(' ');
        int x = hide.Next(words.Length);
        string selectWord = Word.BlankWords(words[x]);
        words[x] = selectWord;
        _scriptureList = string.Join(' ', words);

        _reference = Reference.DisplayReference(index);
        Console.Write($" {_scriptureList} \n");

        // needs to contain number of words in _scriptureList
        // int x = hide.Next(_scriptureList.Count);
        // _text = Word.BlankWords(_scriptureList subX); // ???
        // position in the string for what the word is 
        // underscores need to replace all the letters in that particular word
        // _scriptureList(subX) = subX // ???
        // _reference = Reference.DisplayReference(index);
        // Console.Write($" {_scriptureList} \n");

        // scratch this and turn all the words in the string into an array and use the split.String method to create an array of substrings???
        // strings.join method??? (",") put all the words together with a space between them?
    }


    public bool CompletelyHidden()
    {
    // public CompletelyHidden() : bool
        // search string for any letter upper or lower case until all blanks, if letter, they're not all blanks and need to continue
        // var result = _scriptureList, ".*[a-zA-Z].*");
        var result = Regex.IsMatch(_scriptureList, ".*[a-zA-Z].*");
        return ! result;

    }
}