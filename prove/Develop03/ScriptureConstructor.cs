using System.Runtime.CompilerServices;

public class ScriptureConstructor
{
    private Random rng = new();
    private Dictionary<string, string>[] scriptures = new Dictionary<string, string>[]
    {
        new Dictionary<string, string>
        {
            {"Scripture", "Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven."},
            {"Book", "Matthew"},
            {"Chapter", "5"},
            {"Start Verse", "14"},
            {"End Verse", "16"} //multiple verses
        },
        new Dictionary<string, string>
        {
            {"Scripture", "No man can serve two masters: for either he will hate the one, and love the other; or else he will hold to the one, and despise the other. Ye cannot serve God and mammon."},
            {"Book", "Matthew"},
            {"Chapter", "6"},
            {"Start Verse", "24"} //single verse
        },
        new Dictionary<string, string>
        {
            {"Scripture", "He saith unto them, But whom say ye that I am? And Simon Peter answered and said, Thou art the Christ, the Son of the living God. And Jesus answered and said unto him, Blessed art thou, Simon Bar-jona: for flesh and blood hath not revealed it unto thee, but my Father which is in heaven. And I say also unto thee, That thou art Peter, and upon this rock I will build my church; and the gates of hell shall not prevail against it. And I will give unto thee the keys of the kingdom of heaven: and whatsoever thou shalt bind on earth shall be bound in heaven: and whatsoever thou shalt loose on earth shall be loosed in heaven."},
            {"Book", "Matthew"},
            {"Chapter", "16"},
            {"Start Verse", "15"},
            {"End Verse", "19"}
        },
        new Dictionary<string, string>
        {
            {"Scripture", "And the King shall answer and say unto them, Verily I say unto you, Inasmuch as ye have done it unto one of the least of these my brethren, ye have done it unto me."},
            {"Book", "Matthew"}, 
            {"Chapter", "25"},
            {"Start Verse", "40"}
        },
        new Dictionary<string, string>
        {
            {"Scripture", "And as they thus spake, Jesus himself stood in the midst of them, and saith unto them, Peace be unto you. But they were terrified and affrighted, and supposed that they had seen a spirit. And he said unto them, Why are ye troubled? and why do thoughts arise in your hearts? Behold my hands and my feet, that it is I myself: handle me, and see; for a spirit hath not flesh and bones, as ye see me have."},
            {"Book", "Luke"},
            {"Chapter", "24"},
            {"Start Verse", "36"},
            {"End Verse", "39"}
        },
        new Dictionary<string, string>
        {
            {"Scripture", "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God."},
            {"Book", "John"}, 
            {"Chapter", "3"},
            {"Start Verse", "5"}
        },
        new Dictionary<string, string>
        {
            {"Scripture", "If any man will do his will, he shall know of the doctrine, whether it be of God, or whether I speak of myself."},
            {"Book",  "John"}, 
            {"Chapter", "7"},
            {"Start Verse", "17"}
        },
        new Dictionary<string, string>
        {
            {"Scripture", "And other sheep I have, which are not of this fold: them also I must bring, and they shall hear my voice; and there shall be one fold, and one shepherd."},
            {"Book", "John"},
            {"Chapter", "10"},
            {"Start Verse", "16"}
        },
        new Dictionary<string, string>
        {
            {"Scripture", "If ye love me, keep my commandments."},
            {"Book", "John"},  
            {"Chapter", "14"},
            {"Start Verse", "15"}
        },
         new Dictionary<string, string>
        {
            {"Scripture",  "And this is life eternal, that they might know thee the only true God, and Jesus Christ, whom thou hast sent."},
            {"Book", "John"},
            {"Chapter", "17"},
            {"Start Verse", "3"}
        },

    };
    // private List<string> _scriptureList = new()
    // {
    // "But he, being full of the Holy Ghost, looked up steadfastly into heaven, and saw the glory of God, and Jesus standing on the right hand of God, And said, Behold, I see the heavens opened, and the Son of man standing on the right hand of God.",
    // "For I am not ashamed of the gospel of Christ: for it is the power of God unto salvation to every one that believeth; to the Jew first, and also to the Greek.",
    // "There hath no temptation taken you but such as is common to man: but God is faithful, who will not suffer you to be tempted above that ye are able; but will with the temptation also make a way to escape, that ye may be able to bear it.",
    // "But now is Christ risen from the dead, and become the firstfruits of them that slept. For since by man came death, by man came also the resurrection of the dead. For as in Adam all die, even so in Christ shall all be made alive.",
    // "Else what shall they do which are baptized for the dead, if the dead rise not at all? why are they then baptized for the dead?",
    // "There are also celestial bodies, and bodies terrestrial: but the glory of the celestial is one, and the glory of the terrestrial is another. There is one glory of the sun, and another glory of the moon, and another glory of the stars: for one star differeth from another star in glory. So also is the resurrection of the dead. It is sown in corruption; it is raised in incorruption:",
    // "And he gave some, apostles; and some, prophets; and some, evangelists; and some, pastors and teachers; For the perfecting of the saints, for the work of the ministry, for the edifying of the body of Christ: Till we all come in the unity of the faith, and of the knowledge of the Son of God, unto a perfect man, unto the measure of the stature of the fulness of Christ: That we henceforth be no more children, tossed to and fro, and carried about with every wind of doctrine, by the sleight of men, and cunning craftiness, whereby they lie in wait to deceive;",
    // "Now we beseech you, brethren, by the coming of our Lord Jesus Christ, and by our gathering together unto him, That ye be not soon shaken in mind, or be troubled, neither by spirit, nor by word, nor by letter as from us, as that the day of Christ is at hand. Let no man deceive you by any means: for that day shall not come, except there come a falling away first, and that man of sin be revealed, the son of perdition;",
    // "This know also, that in the last days perilous times shall come. For men shall be lovers of their own selves, covetous, boasters, proud, blasphemers, disobedient to parents, unthankful, unholy, Without natural affection, trucebreakers, false accusers, incontinent, fierce, despisers of those that are good, Traitors, heady, highminded, lovers of pleasures more than lovers of God; Having a form of godliness, but denying the power thereof: from such turn away.",
    // "All scripture is given by inspiration of God, and is profitable for doctrine, for reproof, for correction, for instruction in righteousness: That the man of God may be perfect, throughly furnished unto all good works.",
    // "And no man taketh this honour unto himself, but he that is called of God, as was Aaron.",
    // "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.",
    // "Even so faith, if it hath not works, is dead, being alone. Yea, a man may say, Thou hast faith, and I have works: shew me thy faith without thy works, and I will shew thee my faith by my works.",
    // "And I saw another angel fly in the midst of heaven, having the everlasting gospel to preach unto them that dwell on the earth, and to every nation, and kindred, and tongue, and people, Saying with a loud voice, Fear God, and give glory to him; for the hour of his judgment is come: and worship him that made heaven, and earth, and the sea, and the fountains of waters.",
    // "And I saw the dead, small and great, stand before God; and the books were opened: and another book was opened, which is the book of life: and the dead were judged out of those things which were written in the books, according to their works. And the sea gave up the dead which were in it; and death and hell delivered up the dead which were in them: and they were judged every man according to their works.",
    // };

    // private List<string> _referenceList = new()
    // {
    //     "Acts 7:55-56",
    //     "Romans 1:16",
    //     "1 Corinthians 10:13",
    //     "1 Corinthians 15:20-22",
    //     "1 Corinthians 15:29",
    //     "1 Corinthians 15:40-42",
    //     "Ephesians 4:11-14",
    //     "2 Thessalonians 2:1-3",
    //     "2 Timothy 3:1-5",
    //     "2 Timothy 3:16-17",
    //     "Hebrews 5:4",
    //     "James 1:5-6",
    //     "James 2:17-18",
    //     "Revelation 14:6-7",
    //     "Revelation 20:12-13",
    // };

    public Scripture GetRandomScripture()
    {
        Reference reference;
        int index = rng.Next(scriptures.Length);
        Dictionary<string, string> data = scriptures[index];
        if (data.ContainsKey("End Verse"))
        {
            reference = new(data["Book"], data["Chapter"], data["Start Verse"], data["End Verse"]);
        }
        else
        {
            reference = new(data["Book"], data["Chapter"], data["Start Verse"]);   
        }
        Scripture scripture = new(data["Scripture"], reference);
        return scripture;
    }
}