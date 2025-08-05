// @ts-check

/**
 * Given a certain command, help the chatbot recognize whether the command is valid or not.
 *
 * @param {string} command
 * @returns {boolean} whether or not is the command valid
 */

export function isValidCommand(command) {
  let chatbot = command.split(" ");
  const regex = /Chatbot/gi.test(chatbot[0]);
  return regex;

}

/**
 * Given a certain message, help the chatbot get rid of all the emoji's encryption through the message.
 *
 * @param {string} message
 * @returns {string} The message without the emojis encryption
 */
export function removeEmoji(message) {
const regex = new RegExp(/emoji\d+/gi);
return message.replace(regex, "");
}

/**
 * Given a certain phone number, help the chatbot recognize whether it is in the correct format.
 *
 * @param {string} number
 * @returns {string} the Chatbot response to the phone Validation
 */
export function checkPhoneNumber(number) {
  const regex = new RegExp(/^\(\+\d{2}\) \d{3}-\d{3}-\d{3}$/);
  if (regex.test(number)) {
    return "Thanks! You can now download me to your phone.";
  }
return `Oops, it seems like I can't reach out to ${number}`;
}

/**
 * Given a certain response from the user, help the chatbot get only the URL.
 *
 * @param {string} userInput
 * @returns {string[] | null} all the possible URL's that the user may have answered
 */
export function getURL(userInput) {
  let regex =/[a-z]+\.[a-z]+/g;
  let result = userInput.match(regex);
  return result;
}

/**
 * Greet the user using the full name data from the profile.
 *
 * @param {string} fullName
 * @returns {string} Greeting from the chatbot
 */
export function niceToMeetYou(fullName) {
  const regex = /(\w+), (\w+)$/;
  const result = fullName.replace(regex, "Nice to meet you, $2 $1");
  return result;

}
