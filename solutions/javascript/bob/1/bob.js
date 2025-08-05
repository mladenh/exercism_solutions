export const hey = (message) => {
  const trimString = message.trim();

  if (isEmpty(trimString)) {
    return "Fine. Be that way!";
  }

  if (isQuestion(trimString) && isYelling(trimString)) {
    return "Calm down, I know what I'm doing!";
  }

  if (isQuestion(trimString)) {
    return "Sure.";
  }

  if (isYelling(trimString)) {
    return "Whoa, chill out!";
  }

  return "Whatever.";
};

const isEmpty = (input) => input === "";

const isQuestion = (input) => input.endsWith("?");

const isYelling = (input) =>
  input.toUpperCase() === input && input.toLowerCase() !== input;
