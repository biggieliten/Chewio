using System.ComponentModel.DataAnnotations;

public class UserService
{

	public void ValidateUser(User user)
	{
		var validationContext = new ValidationContext(user);
		var validationResult = new List<ValidationResult>();

		if (!Validator.TryValidateObject(user, validationContext, validationResult, validateAllProperties: true))
		{
			var errors = string.Join("; ", validationResult.Select(r => r.ErrorMessage));
			throw new ValidationException($"User validation failer: {errors}");
		}
	}
}