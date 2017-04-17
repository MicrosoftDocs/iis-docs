/// <summary>
    /// Gets the package's parameters.
    /// </summary>
    public ReadOnlyCollection<PackageParameter> Parameters {
        get {
            Initialize();
            return new ReadOnlyCollection<PackageParameter>(
                (from syncParam in _parameters
                 select new PackageParameter {
                     Name = syncParam.Name,
                     Description = syncParam.Description,
                     Value = syncParam.DefaultValue,
                     IsPassword = IsPassword(syncParam),
                     IsBoolean = IsBoolean(syncParam),
                     ValidationValues = SplitValidationValues(syncParam),
                     AllowEmpty = AllowEmpty(syncParam),
                     RegEx = HasRegEx(syncParam) ? syncParam.Validation.ValidationString : null // if there is no RegEx, allow any value
                 }).ToArray());
        }
    }