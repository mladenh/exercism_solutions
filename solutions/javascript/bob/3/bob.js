export const hey = (message) => {
  const trimmedMessage = message.trim();

  if (/^\s*$/.test(trimmedMessage)) { //^ start of string, \s* any number of whitespace characters, $ end of string
    return "Fine. Be that way!";
  }

  const isQuestion = /\?$/.test(trimmedMessage); //? end of string
  const isYelling = /^[^a-z]*[A-Z][^a-z]*$/.test (trimmedMessage); //^ start of string, [^a-z]* any number of non-lowercase characters, [A-Z] one uppercase character, [^a-z]* any number of non-lowercase characters, $ end of string

/*   return isQuestion
    ? isYelling
      ? "Calm down, I know what I'm doing!"
      : "Sure."
    : isYelling
    ? "Whoa, chill out!"
    : "Whatever."; */

    switch (true) {
      case isQuestion && isYelling:
        return "Calm down, I know what I'm doing!";
      case isQuestion:
        return "Sure.";
      case isYelling:
        return "Whoa, chill out!";
      default:
        return "Whatever.";
    }
};
